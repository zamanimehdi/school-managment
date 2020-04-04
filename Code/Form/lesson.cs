using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_lesson : StyledForms.GoogleTalkForm
    {
        public frm_lesson()
        {
            InitializeComponent();
        }
        private void frm_lesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_lesson.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.ds_lesson.lesson);
            string str;
            if ((str = lessonTableAdapter.getmax().ToString()) != "")
                ds_lesson.lesson.idlessonColumn.AutoIncrementSeed = (long.Parse(str) + 1);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_classdialog form = new frm_classdialog();
            form.txt_classname.MaxLength = 30;
            form.label1.Text = "نام درس";
            form.txt_vahed.Visible = form.lbl_vahed.Visible = true;
            form.button1.Top += 30;
            form.button2.Top += 30;
            form.Height += 30;
            if (form.ShowDialog() == DialogResult.OK && form.idmajor != null && form.grade != null && form.classname != "")
            {
                if (lessonBindingSource.Count == 1)
                    lessonTableAdapter.Fill(ds_lesson.lesson);
                object obj = lessonBindingSource.AddNew();
                ((DataRowView)obj).BeginEdit();
                ((DataRowView)obj)["name"] = form.classname;
                ((DataRowView)obj)["grade"] = form.grade;
                ((DataRowView)obj)["expr1"] = form.majorname;
                ((DataRowView)obj)["idmajor"] = form.idmajor;
                ((DataRowView)obj)["vahed"] = form.vahed;
                ((DataRowView)obj).EndEdit();
                lessonTableAdapter.Update((DataSet.ds_lesson.lessonDataTable)ds_lesson.lesson.GetChanges());
                ds_lesson.lesson.AcceptChanges();
            }
            lessonTableAdapter.Fill(ds_lesson.lesson);
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lessonBindingSource.Current != null)
            {
                frm_classdialog form = new frm_classdialog();
                form.label1.Text = "نام درس";
                form.classname = ((DataRowView)lessonBindingSource.Current)["name"].ToString();
                form.majorname = ((DataRowView)lessonBindingSource.Current)["expr1"].ToString();
                form.grade = ((DataRowView)lessonBindingSource.Current)["grade"].ToString();
                form.txt_vahed.Text = ((DataRowView)lessonBindingSource.Current)["vahed"].ToString();
                form.txt_vahed.Visible = form.lbl_vahed.Visible = true;
                form.button1.Top += 30;
                form.button2.Top += 30;
                form.Height += 30;
                if (form.ShowDialog() == DialogResult.OK && form.idmajor != null && form.grade != null && form.classname != "")
                {
                    if (lessonBindingSource.Count == 1)
                        lessonTableAdapter.Fill(ds_lesson.lesson);
                    object obj = lessonBindingSource.Current;
                    ((DataRowView)obj).BeginEdit();
                    ((DataRowView)obj)["name"] = form.classname;
                    ((DataRowView)obj)["grade"] = form.grade;
                    ((DataRowView)obj)["expr1"] = form.majorname;
                    ((DataRowView)obj)["idmajor"] = form.idmajor;
                    ((DataRowView)obj)["vahed"] = form.vahed;
                    ((DataRowView)obj).EndEdit();
                    lessonTableAdapter.Update((DataSet.ds_lesson.lessonDataTable)ds_lesson.lesson.GetChanges());
                    ds_lesson.lesson.AcceptChanges();
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            frm_messageboxwithpass mb = new frm_messageboxwithpass();
            frm_getpassword gp = new frm_getpassword();
            mb.lbl_messeage.Text = "با پاک کردن یک درس تمامی امتحانات و نمرات ذخیره شده مربوط به آن درس پاک خواهد شد  آیا مطمئن می باشید؟";
            gp.label2.Text = "برای حذف درس رمز را وارد کنید";
            gp.btn_exit.Text = "انصراف";
            if (lessonBindingSource.Count != 0)
            {
                if (mb.ShowDialog()== DialogResult.Yes)
                {
                    if (gp.ShowDialog()== DialogResult.OK)
                    {
                        if (lessonBindingSource.Count == 1)
                            lessonTableAdapter.Fill(ds_lesson.lesson);
                        lessonBindingSource.Remove(lessonBindingSource.Current);
                        lessonTableAdapter.Update((DataSet.ds_lesson.lessonDataTable)ds_lesson.lesson.GetChanges());
                        ds_lesson.lesson.AcceptChanges();
                    }
                }
            }
        }

        private void frm_lesson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode==Keys.E)
                btn_edit_Click(null,null);
        }
    }
}
