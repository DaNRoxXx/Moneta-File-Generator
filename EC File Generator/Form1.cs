using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Troschuetz.Random;

namespace EC_File_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string ValueToId(int value)
        {
            var parts = new List<string>();
            int numberPart = value % 10000;
            parts.Add(numberPart.ToString("0000"));
            value /= 10000;

            for (int i = 0; i < 3 || value > 0; ++i)
            {
                parts.Add(((char)(66 + (value % 26))).ToString());
                value /= 26;
            }

            return string.Join(string.Empty, parts.AsEnumerable().Reverse().ToArray());
        }
        //|| date.Text.Trim() != string.Empty || amount.Text.Trim() != string.Empty || bName.Text.Trim() != string.Empty ||bAddress.Text.Trim() != string.Empty || cnic.Text.Trim() != string.Empty
        private void Generate_Click(object sender, EventArgs e)
        {
            if (crn.Text.Trim() != string.Empty || fName.Text.Trim() != string.Empty ||
                tNum.Text.Trim() != string.Empty || fNum.Text.Trim() != string.Empty) {
                error.Text = "";
                int CRN = Convert.ToInt32(crn.Text);
                int fn = Convert.ToInt32(fNum.Text);
                var nameGenerator = new PersonNameGenerator();
                var trandom = new TRandom();
                if (random.Checked)
                {
                    for (int i = 1; i <= fn; i++)
                    {
                        int tn = Convert.ToInt32(tNum.Text);
                        TextWriter txt = new StreamWriter("E:\\" + fName.Text + i + ".csv");
                        txt.Write("Global ID,Transdate,Foreign Currency Amount,transferamount,transcurrencid,beneficairy name,beneficairy address1,beneficairy address2,beneficariy CNIC,beneficariy Mobile No,beneficairy city,Delivtype,delivdetail1,delivdetail2,delivdetail3,Sender name,Sender Address1,Sender Address2,Sender City,rem stat,remsource Code,Country Code" + (Environment.NewLine));
                        for (; tn > 0; tn--)
                        {
                            txt.Write(ValueToId(CRN) + "," + trandom.Next(1, 31) + "/" + trandom.Next(1, 12) + "/2019" + ",," + trandom.Next(10, 10000) + ",PKR," + nameGenerator.GenerateRandomFirstAndLastName() + "," + bAddress.Text + ",," + "42101" + trandom.Next(11111111, 99999999) + "," + "03" + trandom.Next(0, 999999999) + "," + city.Text + "," + tType.Text + "," + bank.Text + ",,0," + nameGenerator.GenerateRandomFirstAndLastName() + "," + rAddress.Text + ",," + rCity.Text + ",A," + ec.Text + ",1350" + (Environment.NewLine));
                            CRN++;
                        }
                        txt.Close();
                    }
                    error.Text = "File have been generated!";
                }
                else
                {
                    for (int i = 1; i <= fn; i++)
                    {
                        int tn = Convert.ToInt32(tNum.Text);
                        TextWriter txt = new StreamWriter("E:\\" + fName.Text + i + ".csv");
                        txt.Write("Global ID,Transdate,Foreign Currency Amount,transferamount,transcurrencid,beneficairy name,beneficairy address1,beneficairy address2,beneficariy CNIC,beneficariy Mobile No,beneficairy city,Delivtype,delivdetail1,delivdetail2,delivdetail3,Sender name,Sender Address1,Sender Address2,Sender City,rem stat,remsource Code,Country Code" + (Environment.NewLine));
                        for (; tn > 0; tn--)
                        {
                            txt.Write(ValueToId(CRN) + "," + date.Text + ",," + amount.Text + ",PKR," + bName.Text + "," + bAddress.Text + ",," + cnic.Text + "," + number.Text + "," + city.Text + "," + tType.Text + "," + bank.Text + ",,0," + rName.Text + "," + rAddress.Text + ",," + rCity.Text + ",A," + ec.Text + ",1350" + (Environment.NewLine));
                            CRN++;
                        }
                        txt.Close();
                    }
                    error.Text = "File have been generated!";
                }
            }
            else
            {
                error.Text = "All feilds are required to be filled!.";
                return;
            }
            //txt.Write(crn.Text + "," + date.Text + ",," + amount.Text + ",PKR," + bName.Text + "," + bAddress.Text + ",," + cnic.Text + "," + number.Text + "," + city.Text + "," + tType.Text + "," + bank.Text + ",,0," + rName.Text + "," + rAddress.Text + ",," + rCity.Text + ",A," + ec.Text + ",1350" + (Environment.NewLine));

        }

        private void Random_CheckedChanged(object sender, EventArgs e)
        {
            date.Enabled = (random.CheckState != CheckState.Checked);
            amount.Enabled = (random.CheckState != CheckState.Checked);
            bName.Enabled = (random.CheckState != CheckState.Checked);
            rName.Enabled = (random.CheckState != CheckState.Checked);
            cnic.Enabled = (random.CheckState != CheckState.Checked);
            number.Enabled = (random.CheckState != CheckState.Checked);
        }
    }
}
