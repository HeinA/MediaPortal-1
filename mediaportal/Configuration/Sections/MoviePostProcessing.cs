using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPortal.Configuration.Sections
{
	public class MoviePostProcessing : MediaPortal.Configuration.SectionSettings
	{
    private MediaPortal.UserInterface.Controls.MPGroupBox mpGroupBox3;
    private MediaPortal.UserInterface.Controls.MPCheckBox ffdshowCheckBox;
    private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

    public MoviePostProcessing() : this("Movie Post Processing")
    {
    }

		public MoviePostProcessing(string name) : base(name)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

    public override void LoadSettings()
    {
      using (MediaPortal.Profile.Xml xmlreader = new MediaPortal.Profile.Xml("MediaPortal.xml"))
      {
        ffdshowCheckBox.Checked = xmlreader.GetValueAsBool("movieplayer", "ffdshow", false);
      }      
    }

    public override void SaveSettings()
    {
      using (MediaPortal.Profile.Xml xmlwriter = new MediaPortal.Profile.Xml("MediaPortal.xml"))
      {
        xmlwriter.SetValueAsBool("movieplayer", "ffdshow", ffdshowCheckBox.Checked);
      } 
    }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.mpGroupBox3 = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.ffdshowCheckBox = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.mpGroupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // mpGroupBox3
      // 
      this.mpGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.mpGroupBox3.Controls.Add(this.label3);
      this.mpGroupBox3.Controls.Add(this.ffdshowCheckBox);
      this.mpGroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.mpGroupBox3.Location = new System.Drawing.Point(0, 0);
      this.mpGroupBox3.Name = "mpGroupBox3";
      this.mpGroupBox3.Size = new System.Drawing.Size(472, 96);
      this.mpGroupBox3.TabIndex = 7;
      this.mpGroupBox3.TabStop = false;
      this.mpGroupBox3.Text = "Settings";
      // 
      // ffdshowCheckBox
      // 
      this.ffdshowCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.ffdshowCheckBox.Location = new System.Drawing.Point(16, 64);
      this.ffdshowCheckBox.Name = "ffdshowCheckBox";
      this.ffdshowCheckBox.Size = new System.Drawing.Size(184, 16);
      this.ffdshowCheckBox.TabIndex = 8;
      this.ffdshowCheckBox.Text = "Enable FFDshow post processing";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(440, 32);
      this.label3.TabIndex = 10;
      this.label3.Text = "Note that you need to install ffdshow separately to make any this option work. Pl" +
        "ease read the MediaPortal manual for more information.";
      // 
      // MoviePostProcessing
      // 
      this.Controls.Add(this.mpGroupBox3);
      this.Name = "MoviePostProcessing";
      this.Size = new System.Drawing.Size(472, 408);
      this.mpGroupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion
	}
}

