using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.Revit.DB;

using CompareParams.Classes;

namespace CompareParams.UI
{
    public partial class FormCompare : System.Windows.Forms.Form
    {
        private ClsSettings _Settings = null;
        private BindingList<ClsPair> _Pairs = new BindingList<ClsPair>();

        public FormCompare(ClsSettings settings)
        {
            InitializeComponent();
            _Settings = settings;
        }

        void RunComparison()
        {
            ClsCategory catInst = this.comboInst.SelectedItem as ClsCategory;
            ClsCategory catHost = this.comboHost.SelectedItem as ClsCategory;
           
            foreach (Element elem in catInst.InstanceElements)
            {
                try
                {
                    FamilyInstance inst = elem as FamilyInstance;

                    if (inst != null)
                    {
                        Element host = inst.Host;

                        ClsParameter paramInst = new ClsParameter(inst.get_Parameter(this.comboInstProp.SelectedItem.ToString()));
                        ClsParameter paramHost = new ClsParameter(host.get_Parameter(this.comboInstProp.SelectedItem.ToString()));

                        if (paramInst.ParameterObject != null && paramHost.ParameterObject != null)
                        {
                            _Pairs.Add(new ClsPair(inst.Name, host.Name, paramInst.ValueString, paramHost.ValueString));
                        }
                        else
                        {
                            Element instType = _Settings.Doc.GetElement(inst.GetTypeId());
                            Element hostType = _Settings.Doc.GetElement(host.GetTypeId());
                            paramInst = new ClsParameter(instType.get_Parameter(this.comboInstProp.SelectedItem.ToString()));
                            paramHost = new ClsParameter(hostType.get_Parameter(this.comboInstProp.SelectedItem.ToString()));

                            _Pairs.Add(new ClsPair(inst.Name, host.Name, paramInst.ValueString, paramHost.ValueString));
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            LoadResults();
        }

        void UpdateInstParameterList()
        {
            try
            {
                this.comboInstProp.Items.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClsCategory catInst = this.comboInst.SelectedItem as ClsCategory;
            catInst.GetInstanceParameters();

            try
            {
                foreach (ClsParameter param in catInst.InstanceParameters)
                {
                    //if (param.ParameterObject.StorageType == StorageType.String)
                    //{
                    //    // possible handling of string parameters
                    //}
                    //else
                    //{
                        if(!this.comboInstProp.Items.Contains(param.ParameterObject.Definition.Name))
                            this.comboInstProp.Items.Add(param.ParameterObject.Definition.Name);
                    //}
                }
                if (this.comboInstProp.Items != null) this.comboInstProp.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void UpdateHostParameterList()
        {
            try
            {
                this.comboHostProp.Items.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClsCategory catHost = this.comboHost.SelectedItem as ClsCategory;
            catHost.GetInstanceParameters();

            try
            {
                foreach (ClsParameter param in catHost.InstanceParameters)
                {
                    if (param.ParameterObject.StorageType == StorageType.String)
                    {
                        // possible handling of string parameters
                    }
                    else
                    {
                        this.comboHostProp.Items.Add(param.ParameterObject.Definition.Name);
                    }
                }
                if (this.comboHostProp.Items != null) this.comboHostProp.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void LoadResults()
        {
            dataGridView1.DataSource = _Pairs;
        }

        private void FormCompare_Shown(object sender, EventArgs e)
        {
            try
            {
                this.comboInst.DataSource = _Settings.InstCategoryList;
                this.comboInst.DisplayMember = "CatName";
                this.comboInst.SelectedIndex = 0;
                this.comboHost.DataSource = _Settings.HostCategoryList;
                this.comboHost.DisplayMember = "CatName";
                this.comboHost.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInstParameterList();
        }

        private void comboHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHostParameterList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction(_Settings.Doc, "Compare Properties");

            if (t.Start() == TransactionStatus.Started)
            {
                try
                {
                    RunComparison();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.RollBack();
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}
