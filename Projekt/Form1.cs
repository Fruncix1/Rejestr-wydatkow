using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RejestrWydatkow
{
    public partial class Form1 : Form
    {
        private List<Expense> expenses = new List<Expense>();
        private BindingList<string> categories = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            cmbCategory.DataSource = categories;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categories.Add("Jedzenie");
            categories.Add("Transport");
            categories.Add("Rachunki");
            categories.Add("Rozrywka");
            categories.Add("Zakupy");
            categories.Add("Inne");

            cmbCategory.SelectedIndex = 0;

            expenses = FileHelper.LoadExpenses();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = expenses;
            CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Expense expense = new Expense
                {
                    Amount = decimal.Parse(txtAmount.Text),
                    Category = cmbCategory.Text,
                    Date = dtpDate.Value.ToShortDateString(),
                    Description = txtDescription.Text
                };

                expenses.Add(expense);
                FileHelper.SaveExpenses(expenses);
                RefreshGrid();
                ClearFields();
            }
            catch
            {
                MessageBox.Show("Wprowadź poprawną kwotę!",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow != null)
            {
                expenses.RemoveAt(dgvExpenses.CurrentRow.Index);
                FileHelper.SaveExpenses(expenses);
                RefreshGrid();
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (var expense in expenses)
                total += expense.Amount;

            lblTotal.Text = $"Suma wydatków: {total:F2} zł";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvExpenses.DataSource = expenses
                .Where(exp => exp.Category.Contains(txtSearch.Text))
                .ToList();
        }

        private void ClearFields()
        {
            if (txtAmount != null) txtAmount.Text = string.Empty;
            if (txtDescription != null) txtDescription.Text = string.Empty;
            if (dtpDate != null) dtpDate.Value = DateTime.Today;
            if (cmbCategory != null && cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            txtAmount?.Focus();
        }
    }
}