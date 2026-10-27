/*
   Copyright 2016-2022 LIPtoH <liptoh.codebase@gmail.com>

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TS_SE_Tool
{
    partial class FormAboutBox : Form
    {
        FormMain MainForm = Application.OpenForms.OfType<FormMain>().Single();

        public FormAboutBox()
        {
            InitializeComponent();

            SetFormVisual();
            PopulateFormControls();
            TranslateForm();
        }

        private void SetFormVisual()
        {
            this.Icon = Utilities.Graphics_TSSET.IconFromImage(MainForm.ProgUIImgsDict["Info"]);
        }

        private void PopulateFormControls()
        {
            buttonSupportDeveloper.Visible = false;

            labelProductName.Text = Utilities.AssemblyData.AssemblyProduct;
            labelCopyright.Text = Utilities.AssemblyData.AssemblyCopyright;

            labelETS2version.Text = String.Join(" - ", MainForm.SupportedSavefileVersionETS2.Select(p => p.ToString()).ToArray()) + " (" + MainForm.SupportedGameVersionETS2 + ")";
            labelATSversion.Text = "Experimental / not validated in 0.3.12.0 release";
            //
            string[][] referencies = { 
                new string[] {"SII Decrypt", "https://github.com/ncs-sniper/SII_Decrypt"},
                new string[] {"PsColorPicker", "https://github.com/exectails/PsColorPicker"},
                new string[] {"SharpZipLib", "https://github.com/icsharpcode/SharpZipLib"},
                new string[] {"SqlCeBulkCopy", "https://github.com/ErikEJ/SqlCeBulkCopy"},
                new string[] {"DDSImageParser.cs", "https://gist.github.com/soeminnminn/e9c4c99867743a717f5b"},
                new string[] {"TGASharpLib", "https://github.com/ALEXGREENALEX/TGASharpLib"},
                new string[] {"FlexibleMessageBox", "http://www.codeproject.com/Articles/601900/FlexibleMessageBox"},
            };

            string referenciesText = "";

            foreach (string[] tmp in referencies)
            {
                referenciesText += tmp[0] + Environment.NewLine + tmp[1] + Environment.NewLine + Environment.NewLine;
            }
            //
            textBoxDescription.Text = string.Format(MainForm.HelpTranslateString(this.Name + textBoxDescription.Name),
                                                     "liptoh.codebase@gmail.com", "https://github.com/LIPtoH/TS-SE-Tool");

            textBoxDescription.Text += Environment.NewLine + Environment.NewLine +
                                       "Maintained by ThiagoDantas19" + Environment.NewLine +
                                       "Repository: " + Utilities.Web_Utilities.External.linkGithub + Environment.NewLine +
                                       "Based on the community continuation by Fabio (ts-se-tool-community)" + Environment.NewLine +
                                       "Original project by LIPtoH" + Environment.NewLine +
                                       "ETS2 validation: version 1.61 / save format 97" + Environment.NewLine +
                                       "ATS status: experimental / not validated" +
                                       Environment.NewLine + Environment.NewLine;

            textBoxDescription.Text += referenciesText;
            //
        }

        private void TranslateForm()
        {
            MainForm.HelpTranslateFormMethod(this);

            MainForm.HelpTranslateControlExt(this, Utilities.AssemblyData.AssemblyTitle);
            MainForm.HelpTranslateControlExt(labelVersion, Utilities.AssemblyData.AssemblyVersion);
        }

        private void buttonSupportDeveloper_Click(object sender, EventArgs e)
        {
            string url = Utilities.Web_Utilities.External.linkHelpDeveloper;

            DialogResult result = MessageBox.Show("This will open " + url + " web-page." + Environment.NewLine + "Do you want to continue?",
                                                  "Support developer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                System.Diagnostics.Process.Start(url);
        }
    }
}
