<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pos1_btn = New System.Windows.Forms.Button()
        Me.imgpath_btn = New System.Windows.Forms.Button()
        Me.pos1x_txt = New System.Windows.Forms.TextBox()
        Me.lienzo_gb = New System.Windows.Forms.GroupBox()
        Me.total_lbl = New System.Windows.Forms.Label()
        Me.pos2y_txt = New System.Windows.Forms.TextBox()
        Me.y2_lbl = New System.Windows.Forms.Label()
        Me.x2_lbl = New System.Windows.Forms.Label()
        Me.pos2x_txt = New System.Windows.Forms.TextBox()
        Me.pos1y_txt = New System.Windows.Forms.TextBox()
        Me.y1_lbl = New System.Windows.Forms.Label()
        Me.x1_lbl = New System.Windows.Forms.Label()
        Me.pos2_btn = New System.Windows.Forms.Button()
        Me.img_gb = New System.Windows.Forms.GroupBox()
        Me.imgpath_txt = New System.Windows.Forms.TextBox()
        Me.empzr_btn = New System.Windows.Forms.Button()
        Me.control_gb = New System.Windows.Forms.GroupBox()
        Me.vel_num = New System.Windows.Forms.NumericUpDown()
        Me.vel_lbl = New System.Windows.Forms.Label()
        Me.p_txt = New System.Windows.Forms.Label()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.parar_btn = New System.Windows.Forms.Button()
        Me.conti_btn = New System.Windows.Forms.Button()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.pos_timer = New System.Windows.Forms.Timer(Me.components)
        Me.draw_timer = New System.Windows.Forms.Timer(Me.components)
        Me.lienzo_gb.SuspendLayout()
        Me.img_gb.SuspendLayout()
        Me.control_gb.SuspendLayout()
        CType(Me.vel_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pos1_btn
        '
        Me.pos1_btn.Location = New System.Drawing.Point(6, 17)
        Me.pos1_btn.Name = "pos1_btn"
        Me.pos1_btn.Size = New System.Drawing.Size(24, 23)
        Me.pos1_btn.TabIndex = 0
        Me.pos1_btn.Text = "1:"
        Me.pos1_btn.UseVisualStyleBackColor = True
        '
        'imgpath_btn
        '
        Me.imgpath_btn.Location = New System.Drawing.Point(133, 17)
        Me.imgpath_btn.Name = "imgpath_btn"
        Me.imgpath_btn.Size = New System.Drawing.Size(25, 23)
        Me.imgpath_btn.TabIndex = 1
        Me.imgpath_btn.Text = "..."
        Me.imgpath_btn.UseVisualStyleBackColor = True
        '
        'pos1x_txt
        '
        Me.pos1x_txt.Location = New System.Drawing.Point(59, 19)
        Me.pos1x_txt.Name = "pos1x_txt"
        Me.pos1x_txt.Size = New System.Drawing.Size(33, 20)
        Me.pos1x_txt.TabIndex = 2
        Me.pos1x_txt.Text = "0"
        '
        'lienzo_gb
        '
        Me.lienzo_gb.Controls.Add(Me.total_lbl)
        Me.lienzo_gb.Controls.Add(Me.pos2y_txt)
        Me.lienzo_gb.Controls.Add(Me.y2_lbl)
        Me.lienzo_gb.Controls.Add(Me.x2_lbl)
        Me.lienzo_gb.Controls.Add(Me.pos2x_txt)
        Me.lienzo_gb.Controls.Add(Me.pos1y_txt)
        Me.lienzo_gb.Controls.Add(Me.y1_lbl)
        Me.lienzo_gb.Controls.Add(Me.x1_lbl)
        Me.lienzo_gb.Controls.Add(Me.pos1x_txt)
        Me.lienzo_gb.Controls.Add(Me.pos2_btn)
        Me.lienzo_gb.Controls.Add(Me.pos1_btn)
        Me.lienzo_gb.Location = New System.Drawing.Point(7, 1)
        Me.lienzo_gb.Name = "lienzo_gb"
        Me.lienzo_gb.Size = New System.Drawing.Size(164, 87)
        Me.lienzo_gb.TabIndex = 3
        Me.lienzo_gb.TabStop = False
        Me.lienzo_gb.Text = "Lienzo"
        '
        'total_lbl
        '
        Me.total_lbl.AutoSize = True
        Me.total_lbl.Location = New System.Drawing.Point(3, 71)
        Me.total_lbl.Name = "total_lbl"
        Me.total_lbl.Size = New System.Drawing.Size(160, 13)
        Me.total_lbl.TabIndex = 9
        Me.total_lbl.Text = "L: 1080 x 1080 | M: 1080 x 1080"
        '
        'pos2y_txt
        '
        Me.pos2y_txt.Location = New System.Drawing.Point(121, 48)
        Me.pos2y_txt.Name = "pos2y_txt"
        Me.pos2y_txt.Size = New System.Drawing.Size(33, 20)
        Me.pos2y_txt.TabIndex = 8
        Me.pos2y_txt.Text = "0"
        '
        'y2_lbl
        '
        Me.y2_lbl.AutoSize = True
        Me.y2_lbl.Location = New System.Drawing.Point(98, 51)
        Me.y2_lbl.Name = "y2_lbl"
        Me.y2_lbl.Size = New System.Drawing.Size(17, 13)
        Me.y2_lbl.TabIndex = 7
        Me.y2_lbl.Text = "Y:"
        '
        'x2_lbl
        '
        Me.x2_lbl.AutoSize = True
        Me.x2_lbl.Location = New System.Drawing.Point(36, 51)
        Me.x2_lbl.Name = "x2_lbl"
        Me.x2_lbl.Size = New System.Drawing.Size(17, 13)
        Me.x2_lbl.TabIndex = 5
        Me.x2_lbl.Text = "X:"
        '
        'pos2x_txt
        '
        Me.pos2x_txt.Location = New System.Drawing.Point(59, 48)
        Me.pos2x_txt.Name = "pos2x_txt"
        Me.pos2x_txt.Size = New System.Drawing.Size(33, 20)
        Me.pos2x_txt.TabIndex = 6
        Me.pos2x_txt.Text = "0"
        '
        'pos1y_txt
        '
        Me.pos1y_txt.Location = New System.Drawing.Point(121, 19)
        Me.pos1y_txt.Name = "pos1y_txt"
        Me.pos1y_txt.Size = New System.Drawing.Size(33, 20)
        Me.pos1y_txt.TabIndex = 4
        Me.pos1y_txt.Text = "0"
        '
        'y1_lbl
        '
        Me.y1_lbl.AutoSize = True
        Me.y1_lbl.Location = New System.Drawing.Point(98, 22)
        Me.y1_lbl.Name = "y1_lbl"
        Me.y1_lbl.Size = New System.Drawing.Size(17, 13)
        Me.y1_lbl.TabIndex = 3
        Me.y1_lbl.Text = "Y:"
        '
        'x1_lbl
        '
        Me.x1_lbl.AutoSize = True
        Me.x1_lbl.Location = New System.Drawing.Point(36, 22)
        Me.x1_lbl.Name = "x1_lbl"
        Me.x1_lbl.Size = New System.Drawing.Size(17, 13)
        Me.x1_lbl.TabIndex = 2
        Me.x1_lbl.Text = "X:"
        '
        'pos2_btn
        '
        Me.pos2_btn.Location = New System.Drawing.Point(6, 46)
        Me.pos2_btn.Name = "pos2_btn"
        Me.pos2_btn.Size = New System.Drawing.Size(24, 23)
        Me.pos2_btn.TabIndex = 1
        Me.pos2_btn.Text = "2:"
        Me.pos2_btn.UseVisualStyleBackColor = True
        '
        'img_gb
        '
        Me.img_gb.Controls.Add(Me.imgpath_txt)
        Me.img_gb.Controls.Add(Me.imgpath_btn)
        Me.img_gb.Location = New System.Drawing.Point(7, 88)
        Me.img_gb.Name = "img_gb"
        Me.img_gb.Size = New System.Drawing.Size(164, 49)
        Me.img_gb.TabIndex = 4
        Me.img_gb.TabStop = False
        Me.img_gb.Text = "Imagen (BITMAP)"
        '
        'imgpath_txt
        '
        Me.imgpath_txt.Location = New System.Drawing.Point(6, 19)
        Me.imgpath_txt.Name = "imgpath_txt"
        Me.imgpath_txt.Size = New System.Drawing.Size(121, 20)
        Me.imgpath_txt.TabIndex = 0
        '
        'empzr_btn
        '
        Me.empzr_btn.Location = New System.Drawing.Point(2, 19)
        Me.empzr_btn.Name = "empzr_btn"
        Me.empzr_btn.Size = New System.Drawing.Size(54, 23)
        Me.empzr_btn.TabIndex = 2
        Me.empzr_btn.Text = "EMPZR"
        Me.empzr_btn.UseVisualStyleBackColor = True
        '
        'control_gb
        '
        Me.control_gb.Controls.Add(Me.vel_num)
        Me.control_gb.Controls.Add(Me.vel_lbl)
        Me.control_gb.Controls.Add(Me.p_txt)
        Me.control_gb.Controls.Add(Me.pbar)
        Me.control_gb.Controls.Add(Me.parar_btn)
        Me.control_gb.Controls.Add(Me.empzr_btn)
        Me.control_gb.Controls.Add(Me.conti_btn)
        Me.control_gb.Location = New System.Drawing.Point(7, 137)
        Me.control_gb.Name = "control_gb"
        Me.control_gb.Size = New System.Drawing.Size(164, 96)
        Me.control_gb.TabIndex = 5
        Me.control_gb.TabStop = False
        Me.control_gb.Text = "Control"
        '
        'vel_num
        '
        Me.vel_num.Location = New System.Drawing.Point(26, 67)
        Me.vel_num.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.vel_num.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vel_num.Name = "vel_num"
        Me.vel_num.Size = New System.Drawing.Size(132, 20)
        Me.vel_num.TabIndex = 8
        Me.vel_num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'vel_lbl
        '
        Me.vel_lbl.AutoSize = True
        Me.vel_lbl.Location = New System.Drawing.Point(3, 69)
        Me.vel_lbl.Name = "vel_lbl"
        Me.vel_lbl.Size = New System.Drawing.Size(28, 13)
        Me.vel_lbl.TabIndex = 7
        Me.vel_lbl.Text = "Vel: "
        '
        'p_txt
        '
        Me.p_txt.AutoSize = True
        Me.p_txt.Location = New System.Drawing.Point(129, 48)
        Me.p_txt.Name = "p_txt"
        Me.p_txt.Size = New System.Drawing.Size(21, 13)
        Me.p_txt.TabIndex = 6
        Me.p_txt.Text = "0%"
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(3, 43)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(124, 23)
        Me.pbar.Step = 1
        Me.pbar.TabIndex = 5
        '
        'parar_btn
        '
        Me.parar_btn.Location = New System.Drawing.Point(55, 19)
        Me.parar_btn.Name = "parar_btn"
        Me.parar_btn.Size = New System.Drawing.Size(54, 23)
        Me.parar_btn.TabIndex = 4
        Me.parar_btn.Text = "PARAR"
        Me.parar_btn.UseVisualStyleBackColor = True
        '
        'conti_btn
        '
        Me.conti_btn.Location = New System.Drawing.Point(108, 19)
        Me.conti_btn.Name = "conti_btn"
        Me.conti_btn.Size = New System.Drawing.Size(54, 23)
        Me.conti_btn.TabIndex = 3
        Me.conti_btn.Text = "CONTI"
        Me.conti_btn.UseVisualStyleBackColor = True
        '
        'pos_timer
        '
        '
        'draw_timer
        '
        Me.draw_timer.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 235)
        Me.Controls.Add(Me.control_gb)
        Me.Controls.Add(Me.img_gb)
        Me.Controls.Add(Me.lienzo_gb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(192, 274)
        Me.MinimumSize = New System.Drawing.Size(192, 274)
        Me.Name = "Form1"
        Me.Text = "PintuBot"
        Me.lienzo_gb.ResumeLayout(False)
        Me.lienzo_gb.PerformLayout()
        Me.img_gb.ResumeLayout(False)
        Me.img_gb.PerformLayout()
        Me.control_gb.ResumeLayout(False)
        Me.control_gb.PerformLayout()
        CType(Me.vel_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pos1_btn As Button
    Friend WithEvents imgpath_btn As Button
    Friend WithEvents pos1x_txt As TextBox
    Friend WithEvents lienzo_gb As GroupBox
    Friend WithEvents pos2y_txt As TextBox
    Friend WithEvents y2_lbl As Label
    Friend WithEvents x2_lbl As Label
    Friend WithEvents pos2x_txt As TextBox
    Friend WithEvents pos1y_txt As TextBox
    Friend WithEvents y1_lbl As Label
    Friend WithEvents x1_lbl As Label
    Friend WithEvents pos2_btn As Button
    Friend WithEvents img_gb As GroupBox
    Friend WithEvents imgpath_txt As TextBox
    Friend WithEvents empzr_btn As Button
    Friend WithEvents control_gb As GroupBox
    Friend WithEvents p_txt As Label
    Friend WithEvents pbar As ProgressBar
    Friend WithEvents parar_btn As Button
    Friend WithEvents conti_btn As Button
    Friend WithEvents OpenFile As OpenFileDialog
    Friend WithEvents total_lbl As Label
    Friend WithEvents pos_timer As Timer
    Friend WithEvents draw_timer As Timer
    Friend WithEvents vel_num As NumericUpDown
    Friend WithEvents vel_lbl As Label
End Class
