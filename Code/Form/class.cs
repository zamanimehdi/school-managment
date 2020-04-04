using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_class : StyledForms.GoogleTalkForm
    {
        public frm_class()
        {
            InitializeComponent();
        }
        private void frm_class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_class._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_class._class);
            string str;
            if ((str = classTableAdapter.getmax().ToString()) != "")
                ds_class._class.idclassColumn.AutoIncrementSeed = (long.Parse(str) + 1);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_classdialog form = new frm_classdialog();
            form.txt_classname.MaxLength = 15;
            if (form.ShowDialog() == DialogResult.OK && form.idmajor != null && form.grade != null && form.classname != "")
            {
                if (classBindingSource.Count == 1)
                    classTableAdapter.Fill(ds_class._class);
                object obj = classBindingSource.AddNew();
                ((DataRowView)obj).BeginEdit();
                ((DataRowView)obj)["name"] = form.classname;
                ((DataRowView)obj)["grade"] = form.grade;
                ((DataRowView)obj)["majorname"] = form.majorname;
                ((DataRowView)obj)["idmajor"] = form.idmajor;
                ((DataRowView)obj).EndEdit();
                classTableAdapter.Update((DataSet.ds_class.classDataTable)ds_class._class.GetChanges());
                ds_class._class.AcceptChanges();
            }
            classTableAdapter.Fill(ds_class._class);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (classBindingSource.Current != null)
            {
                frm_classdialog form = new frm_classdialog();
                form.classname = ((DataRowView)classBindingSource.Current)["name"].ToString();
                form.majorname = ((DataRowView)classBindingSource.Current)["majorname"].ToString();
                form.grade = ((DataRowView)classBindingSource.Current)["grade"].ToString();
                if (form.ShowDialog() == DialogResult.OK && form.idmajor != null && form.grade != null && form.classname != "")
                {
                    if (classBindingSource.Count == 1)
                        classTableAdapter.Fill(ds_class._class);
                    object obj = classBindingSource.Current;
                    ((DataRowView)obj).BeginEdit();
                    ((DataRowView)obj)["name"] = form.classname;
                    ((DataRowView)obj)["grade"] = form.grade;
                    ((DataRowView)obj)["majorname"] = form.majorname;
                    ((DataRowView)obj)["idmajor"] = form.idmajor;
                    ((DataRowView)obj).EndEdit();
                    classTableAdapter.Update((DataSet.ds_class.classDataTable)ds_class._class.GetChanges());
                    ds_class._class.AcceptChanges();
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            frm_messageboxwithpass mb = new frm_messageboxwithpass();
            frm_getpassword gp = new frm_getpassword();
            mb.lbl_messeage.Text = "با پاک کردن یک کلاس تمامی دانش آموزان و همچنین امتحانات برگذار شده در آن پاک خواهد شد  آیا مطمئن می باشید؟";
            gp.label2.Text = "برای حذف کلاس رمز را وارد کنید";
            gp.btn_exit.Text = "انصراف";
            if (classBindingSource.Count != 0)
            {
                if (mb.ShowDialog()== DialogResult.Yes)
                {
                    if (gp.ShowDialog()== DialogResult.OK)
                    {
                        if (classBindingSource.Count == 1)
                            classTableAdapter.Fill(ds_class._class);
                        classBindingSource.Remove(classBindingSource.Current);
                        classTableAdapter.Update((DataSet.ds_class.classDataTable)ds_class._class.GetChanges());
                        ds_class._class.AcceptChanges();
                    }
                }
            }
        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.E)
                btn_edit_Click(null, null);
        }
    }
}
