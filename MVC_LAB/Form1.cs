using MVC_LAB.model.intefaces;
using MVC_LAB.model;
using MVC_LAB.model.solutions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_LAB.model.core;

namespace MVC_LAB
{
    public partial class Form1 : Form
    {
        private const int STR_LEN = 4;
        private IModel model = new Model();
        private ISolution solution = new NearestNeighborMethod();

        public Form1()
        {
            InitializeComponent();
        }

        private void repaintTableView()
        {
            List<String> names = model.getPointsNames();
            this.matrixView.ColumnCount = names.Count + 1;
            this.matrixView.RowCount = this.matrixView.ColumnCount;

            for (int i = 0; i < names.Count; ++i)
            {
                this.matrixView[i + 1, 0].Value = names[i];
                this.matrixView[0, i + 1].Value = names[i];
            }

            int count = model.countOfPoints;
            for (int r = 1; r <= count; ++r)
            {
                for (int c = 1; c <= count; ++c)
                {
                    this.matrixView[r, c].Value = model.CostsMatrix[r - 1, c - 1];
                }
            }

            for (int i = 0; i < this.matrixView.Columns.Count; ++i)
            {
                this.matrixView.Columns[i].Width = 24;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            model.resizeCostsMatrix(Convert.ToInt32(this.numericPointsCount.Value));
            repaintTableView();

        }

        private void matrixView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void matrixView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == e.RowIndex)
                e.Cancel = true;
        }
        private void matrixView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            model.setCostsMatrixValue(r - 1, c - 1, Convert.ToInt32(matrixView[r, c].Value));

        }

        private void matrixView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;

            matrixView[r, c].Value = matrixView[c, r].Value;
            
        }

        private void matrixView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.RowIndex == 0) { return; }
            this.matrixView.Rows[e.RowIndex].ErrorText = "";
            int newInteger;

            if (this.matrixView.Rows[e.RowIndex].IsNewRow)
            { return; }
            if (!int.TryParse(e.FormattedValue.ToString(), out newInteger))
            {
                e.Cancel = true;
                this.matrixView.Rows[e.RowIndex].ErrorText = "The value must be an integer";
            }
        }

        private void randFill_Click(object sender, EventArgs e)
        {
            this.model.randFillCostsMatrix(10, 100);
            repaintTableView();
        }

        private void findSolution_Click(object sender, EventArgs e)
        {
            this.solution.findSolution(this.model);
            int[,] m = this.model.CostsMatrix;

            List<String> names = this.model.getPointsNames();

            for (int i = 0; i < STR_LEN; ++i)
            {
                this.solutionsBox.Items.Add("");
            }


            string line = monoString("", STR_LEN + 2);
            foreach (String name in names)
            {
                line += monoString(name, STR_LEN + 1);
            }
            this.solutionsBox.Items.Add(line);
            
            
            for (int r = 0; r < this.model.countOfPoints; ++r)
            {
                line = monoString(names[r], STR_LEN + 1);
                for (int c = 0; c < this.model.countOfPoints; ++c)
                {
                    line += " " + monoString(m[r, c].ToString(), STR_LEN);
                }
                this.solutionsBox.Items.Add(line);
            }

            line = "Solution: ";
            List<Point> points = this.solution.getLastBestWay();
            for (int i = 0; i < points.Count; ++i)
            {
                line += points[i].Name;
                if (i != points.Count - 1)
                {
                    line += "->";
                }
            }
            this.solutionsBox.Items.Add(line);
            line = "Cost: " + this.solution.getLastBestCost();
            this.solutionsBox.Items.Add(line);

        }

        private void solutionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string monoString(string str, int l)
        {
            
            while(str.Length < l)
            {
                str += " ";
            }
            return str;
        }
    }

}
