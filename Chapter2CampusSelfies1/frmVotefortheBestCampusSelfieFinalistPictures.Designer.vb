<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVotefortheBestCampusSelfieFinalistPictures
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnFinalistCheer = New System.Windows.Forms.Button()
        Me.btnFinalistConnect = New System.Windows.Forms.Button()
        Me.PicSelfie1 = New System.Windows.Forms.PictureBox()
        Me.PicSelfie2 = New System.Windows.Forms.PictureBox()
        Me.btnSelectSelfie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExitWindow = New System.Windows.Forms.Button()
        CType(Me.PicSelfie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSelfie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(163, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(448, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Vote for the Best Campus Selfie"
        '
        'btnFinalistCheer
        '
        Me.btnFinalistCheer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalistCheer.Location = New System.Drawing.Point(130, 96)
        Me.btnFinalistCheer.Name = "btnFinalistCheer"
        Me.btnFinalistCheer.Size = New System.Drawing.Size(204, 44)
        Me.btnFinalistCheer.TabIndex = 1
        Me.btnFinalistCheer.Text = "Finalist ""Cheer"""
        Me.btnFinalistCheer.UseVisualStyleBackColor = True
        '
        'btnFinalistConnect
        '
        Me.btnFinalistConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalistConnect.Location = New System.Drawing.Point(451, 96)
        Me.btnFinalistConnect.Name = "btnFinalistConnect"
        Me.btnFinalistConnect.Size = New System.Drawing.Size(197, 44)
        Me.btnFinalistConnect.TabIndex = 2
        Me.btnFinalistConnect.Text = "Finalist ""Connect"""
        Me.btnFinalistConnect.UseVisualStyleBackColor = True
        '
        'PicSelfie1
        '
        Me.PicSelfie1.Location = New System.Drawing.Point(130, 186)
        Me.PicSelfie1.Name = "PicSelfie1"
        Me.PicSelfie1.Size = New System.Drawing.Size(204, 129)
        Me.PicSelfie1.TabIndex = 3
        Me.PicSelfie1.TabStop = False
        '
        'PicSelfie2
        '
        Me.PicSelfie2.Location = New System.Drawing.Point(451, 186)
        Me.PicSelfie2.Name = "PicSelfie2"
        Me.PicSelfie2.Size = New System.Drawing.Size(207, 129)
        Me.PicSelfie2.TabIndex = 4
        Me.PicSelfie2.TabStop = False
        '
        'btnSelectSelfie
        '
        Me.btnSelectSelfie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSelfie.Location = New System.Drawing.Point(323, 345)
        Me.btnSelectSelfie.Name = "btnSelectSelfie"
        Me.btnSelectSelfie.Size = New System.Drawing.Size(158, 42)
        Me.btnSelectSelfie.TabIndex = 5
        Me.btnSelectSelfie.Text = "Select Selfie"
        Me.btnSelectSelfie.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(105, 404)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(596, 25)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose the best selfie and then click the Select Selfie button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(302, 429)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(179, 25)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Thanks for voting"
        '
        'btnExitWindow
        '
        Me.btnExitWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitWindow.Location = New System.Drawing.Point(323, 470)
        Me.btnExitWindow.Name = "btnExitWindow"
        Me.btnExitWindow.Size = New System.Drawing.Size(158, 37)
        Me.btnExitWindow.TabIndex = 8
        Me.btnExitWindow.Text = "Exit Window"
        Me.btnExitWindow.UseVisualStyleBackColor = True
        '
        'frmVotefortheBestCampusSelfieFinalistPictures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 534)
        Me.Controls.Add(Me.btnExitWindow)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSelectSelfie)
        Me.Controls.Add(Me.PicSelfie2)
        Me.Controls.Add(Me.PicSelfie1)
        Me.Controls.Add(Me.btnFinalistConnect)
        Me.Controls.Add(Me.btnFinalistCheer)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmVotefortheBestCampusSelfieFinalistPictures"
        Me.Text = "Vote for the Best Campus Selfie Finalist Pictures"
        CType(Me.PicSelfie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSelfie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnFinalistCheer As Button
    Friend WithEvents btnFinalistConnect As Button
    Friend WithEvents PicSelfie1 As PictureBox
    Friend WithEvents PicSelfie2 As PictureBox
    Friend WithEvents btnSelectSelfie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExitWindow As Button
End Class
