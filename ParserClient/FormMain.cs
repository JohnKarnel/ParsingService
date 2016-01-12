using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParserClient.ParserService;

namespace ParserClient
{
    public partial class FormMain : Form
    {
        ParsingServiceClient _client;
        private List<string> _bankUrls = new List<string>()
        {
            "http://finance.i.ua/bank/73/",
            "http://finance.i.ua/bank/29/",
            "http://finance.i.ua/bank/2/",
            "http://finance.i.ua/bank/79/",
            "http://finance.i.ua/bank/26/",
            "http://finance.i.ua/bank/9/",
            "http://finance.i.ua/bank/8/",
            "http://finance.i.ua/bank/4/",
            "http://finance.i.ua/bank/23/",
            "http://finance.i.ua/bank/13/",
            "http://finance.i.ua/bank/12/",
            "http://finance.i.ua/bank/30/",
            "http://finance.i.ua/bank/52/"
        };
        public FormMain()
        {
            InitializeComponent();
            _client = new ParsingServiceClient("BasicHttpBinding_IParsingService");
        }

        private void btn_Parse_Click(object sender, EventArgs e)
        {
            //парсим указаный масив url адресов и получаем масив банков
            List<Bank> banks = _client.ParseThePages(_bankUrls.ToArray<string>()).ToList<Bank>();
            //вычесляем количество строк таблицы
            dgv_ExchangeRate.RowCount = banks.Count;
            //заполняем таблицу информацией о банках
            FillTheDataGridView(banks);
        }

        private void FillTheDataGridView(List<Bank> banks)
        {
            for (int i = 0; i < dgv_ExchangeRate.RowCount; i++)
            {
                dgv_ExchangeRate[0, i].Value = banks[i].Name;
                dgv_ExchangeRate[1, i].Value = banks[i].UsdBuy;
                dgv_ExchangeRate[2, i].Value = banks[i].UsdSale;
                dgv_ExchangeRate[3, i].Value = banks[i].EurBuy;
                dgv_ExchangeRate[4, i].Value = banks[i].EurSale;
                dgv_ExchangeRate[5, i].Value = banks[i].RubBuy;
                dgv_ExchangeRate[6, i].Value = banks[i].RubSale;
            }
        }
    }
}
