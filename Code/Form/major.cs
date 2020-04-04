using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_major : StyledForms.GoogleTalkForm
    {
        public frm_major()
        {
            InitializeComponent();
        }
        private void frm_major_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_major.major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.ds_major.major);
            string str;
            if ((str = majorTableAdapter.getmax().ToString()) != "")
                ds_major.major.idmajorColumn.AutoIncrementSeed = (long.Parse(str) + 1);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_mini_dialog form = new frm_mini_dialog();
            if (form.ShowDialog() == DialogResult.OK && form.result!="")
            {
                if (majorBindingSource.Count == 1)
                    majorTableAdapter.Fill(ds_major.major);
                object obj=majorBindingSource.AddNew();
                ((DataRowView)obj).BeginEdit();
                ((DataRowView)obj)["name"] = form.result;
                ((DataRowView)obj).EndEdit();
                majorTableAdapter.Update((DataSet.ds_major.majorDataTable)ds_major.major.GetChanges());
                ds_major.major.AcceptChanges();
            }
            majorTableAdapter.Fill(ds_major.major);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (majorBindingSource.Current != null)
            {
                frm_mini_dialog form = new frm_mini_dialog();
                form.result = ((DataRowView)majorBindingSource.Current)["name"].ToString();
                if (form.ShowDialog() == DialogResult.OK && form.result != "")
                {
                    if (majorBindingSource.Count == 1)
                        majorTableAdapter.Fill(ds_major.major);
                    object obj = majorBindingSource.Current;
                    ((DataRowView)obj).BeginEdit();
                    ((DataRowView)obj)["name"] = form.result;
                    ((DataRowView)obj).EndEdit();
                    majorTableAdapter.Update((DataSet.ds_major.majorDataTable)ds_major.major.GetChanges());
                    ds_major.major.AcceptChanges();
                }
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            frm_messageboxwithpass mb = new frm_messageboxwithpass();
            frm_getpassword gp = new frm_getpassword();
            mb.lbl_messeage.Text = "با پاک کردن یک رشته تمامی دروس و امتحانات همچنین دانش آموزان در حال تحصیل در آن رشته پاک خواهد شد  آیا مطمئن می باشید؟";
            gp.label2.Text = "برای حذف رشته رمز را وارد کنید";
            gp.btn_exit.Text = "انصراف";
            if (majorBindingSource.Count != 0)
            {
                if (mb.ShowDialog()== DialogResult.Yes)
                {
                    
                    if (gp.ShowDialog() == DialogResult.OK)
                    {
                        if (majorBindingSource.Count == 1)
                            majorTableAdapter.Fill(ds_major.major);
                        majorBindingSource.Remove(majorBindingSource.Current);
                        majorTableAdapter.Update((DataSet.ds_major.majorDataTable)ds_major.major.GetChanges());
                        ds_major.major.AcceptChanges();
                    }
                }
            }
        }
    }
}