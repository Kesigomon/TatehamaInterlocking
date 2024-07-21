using System.ComponentModel;

namespace TatehamaInterlocking.Tatehama;

partial class TatehamaWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BT_1R = new Button();
        BT_2R = new Button();
        BT_3R = new Button();
        BT_4R = new Button();
        BT_5LA = new Button();
        BT_5LB = new Button();
        BT_5LC = new Button();
        BT_5LD = new Button();
        SuspendLayout();
        // 
        // button2
        // 
        BT_1R.Location = new Point(161, 83);
        BT_1R.Name = "BT_1R";
        BT_1R.Size = new Size(289, 65);
        BT_1R.TabIndex = 0;
        BT_1R.Text = "館浜上り出発1R";
        BT_1R.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        BT_2R.Location = new Point(161, 165);
        BT_2R.Name = "BT_2R";
        BT_2R.Size = new Size(289, 65);
        BT_2R.TabIndex = 1;
        BT_2R.Text = "館浜上り出発2R";
        BT_2R.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        BT_3R.Location = new Point(161, 253);
        BT_3R.Name = "BT_3R";
        BT_3R.Size = new Size(289, 65);
        BT_3R.TabIndex = 2;
        BT_3R.Text = "館浜上り出発3R";
        BT_3R.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        BT_4R.Location = new Point(161, 403);
        BT_4R.Name = "BT_4R";
        BT_4R.Size = new Size(289, 65);
        BT_4R.TabIndex = 3;
        BT_4R.Text = "館浜上り出発4R";
        BT_4R.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        BT_5LA.Location = new Point(847, 269);
        BT_5LA.Name = "BT_5LA";
        BT_5LA.Size = new Size(289, 65);
        BT_5LA.TabIndex = 4;
        BT_5LA.Text = "館浜下り場内5LA";
        BT_5LA.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        BT_5LB.Location = new Point(847, 353);
        BT_5LB.Name = "BT_5LB";
        BT_5LB.Size = new Size(289, 65);
        BT_5LB.TabIndex = 5;
        BT_5LB.Text = "館浜下り場内5LB";
        BT_5LB.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        BT_5LC.Location = new Point(847, 445);
        BT_5LC.Name = "BT_5LC";
        BT_5LC.Size = new Size(289, 65);
        BT_5LC.TabIndex = 6;
        BT_5LC.Text = "館浜下り場内5LC";
        BT_5LC.UseVisualStyleBackColor = true;
        // 
        // button9
        // 
        BT_5LD.Location = new Point(847, 535);
        BT_5LD.Name = "BT_5LD";
        BT_5LD.Size = new Size(289, 65);
        BT_5LD.TabIndex = 7;
        BT_5LD.Text = "館浜下り場内5LD";
        BT_5LD.UseVisualStyleBackColor = true;
        // 
        // TatehamaWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.Tatehama;
        ClientSize = new Size(1496, 648);
        Controls.Add(BT_5LD);
        Controls.Add(BT_5LC);
        Controls.Add(BT_5LB);
        Controls.Add(BT_5LA);
        Controls.Add(BT_4R);
        Controls.Add(BT_3R);
        Controls.Add(BT_2R);
        Controls.Add(BT_1R);
        Name = "TatehamaWindow";
        Text = "TatehamaWindow";
        ResumeLayout(false);
    }


    #endregion

    private Button BT_1R;
    private Button BT_2R;
    private Button BT_3R;
    private Button BT_4R;
    private Button BT_5LA;
    private Button BT_5LB;
    private Button BT_5LC;
    private Button BT_5LD;
}