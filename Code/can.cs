using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    class can
    {
        public void recolortextbox(GroupBox grp)
        {

            for (int i = 0; i < grp.Controls.Count; i++)
                if (grp.Controls[i] is TextBox || grp.Controls[i] is ComboBox)
                    grp.Controls[i].BackColor = System.Drawing.Color.Empty;
        }
        public bool checkempty(params Control[] txtar)
        {
            bool isn = true;
            foreach (Control txtb in txtar)
            {
                if (txtb.Text == "")
                {
                    isn = false;
                    txtb.BackColor = System.Drawing.Color.LightPink;
                }
            }
            return isn;
        }
        public bool isnumber(params TextBox[] txtar)
        {

            bool isn = true;
            foreach (TextBox txtb in txtar)
            {
                bool isone = true;
                for (int i = 0; i < txtb.Text.Length; i++)
                {
                    if (char.IsNumber(txtb.Text[i]) != true && isone == true)
                    {
                        isone = false;
                        isn = false;
                    }
                }
                if (!isone) txtb.BackColor = System.Drawing.Color.LightPink;
                else txtb.BackColor = System.Drawing.Color.Empty;
            }
            return isn;
        }
        public bool isnumber(string str)
        {
            bool isn = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]) != true)
                    isn = false;
            }
            return isn;
        }

        public bool isstring(params TextBox[] txtar)
        {

            bool isn = true;
            foreach (TextBox txtb in txtar)
            {
                bool isone = true;
                for (int i = 0; i < txtb.Text.Length; i++)
                {
                    if ((char.IsLetter(txtb.Text[i]) != true && txtb.Text[i] != ' ') && isone == true)
                    {
                        isone = false;
                        isn = false;
                    }
                }
                if (!isone) txtb.BackColor = System.Drawing.Color.LightPink;
                else txtb.BackColor = System.Drawing.Color.Empty;
            }
            return isn;
        }
        public bool isdate(TextBox txtb)
        {

            bool isn = true;
            if (txtb.Text.Length != 6) isn = false;
            if (!isnumber(txtb.Text)) isn = false;
            if (isn)
            {
                if (Int32.Parse(txtb.Text.Substring(0, 2)) < 84 || Int32.Parse(txtb.Text.Substring(0, 2)) > 99)
                    isn = false;
                else
                    if (Int32.Parse(txtb.Text.Substring(2, 2)) < 1 || Int32.Parse(txtb.Text.Substring(2, 2)) > 12)
                        isn = false;
                    else
                        if (Int32.Parse(txtb.Text.Substring(4, 2)) < 1 || Int32.Parse(txtb.Text.Substring(4, 2)) > 31)
                            isn = false;
            }
            if (!isn) txtb.BackColor = System.Drawing.Color.LightPink;
            else txtb.BackColor = System.Drawing.Color.Empty;
            return isn;
        }
        public void datetostandard(string str)
        {
            str.Insert(2, "/").Insert(5, "/");
        }
    }
}
