<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.cb_type = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnt_clearall = New System.Windows.Forms.Button()
        Me.tb_filename = New System.Windows.Forms.TextBox()
        Me.tb_UID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.cb_foldername = New System.Windows.Forms.ComboBox()
        Me.lb_table = New System.Windows.Forms.Label()
        Me.tb_tablename = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(16, 228)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(627, 99)
        Me.DataGridViewTable.TabIndex = 45
        '
        'tb_input
        '
        Me.tb_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_input.Location = New System.Drawing.Point(4, 190)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(624, 20)
        Me.tb_input.TabIndex = 44
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(547, 106)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 23)
        Me.btn_save.TabIndex = 43
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(441, 106)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 42
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(547, 48)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(84, 23)
        Me.btn_refresh.TabIndex = 39
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(441, 48)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 23)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'cb_type
        '
        Me.cb_type.FormattingEnabled = True
        Me.cb_type.Items.AddRange(New Object() {"-SQLite", "-Access"})
        Me.cb_type.Location = New System.Drawing.Point(78, 129)
        Me.cb_type.Name = "cb_type"
        Me.cb_type.Size = New System.Drawing.Size(190, 21)
        Me.cb_type.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Folder Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "File Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "UID"
        '
        'bnt_clearall
        '
        Me.bnt_clearall.Location = New System.Drawing.Point(547, 19)
        Me.bnt_clearall.Name = "bnt_clearall"
        Me.bnt_clearall.Size = New System.Drawing.Size(84, 23)
        Me.bnt_clearall.TabIndex = 28
        Me.bnt_clearall.Text = "Clear All"
        Me.bnt_clearall.UseVisualStyleBackColor = True
        '
        'tb_filename
        '
        Me.tb_filename.Location = New System.Drawing.Point(78, 50)
        Me.tb_filename.Name = "tb_filename"
        Me.tb_filename.Size = New System.Drawing.Size(190, 20)
        Me.tb_filename.TabIndex = 26
        '
        'tb_UID
        '
        Me.tb_UID.Location = New System.Drawing.Point(78, 25)
        Me.tb_UID.Name = "tb_UID"
        Me.tb_UID.Size = New System.Drawing.Size(100, 20)
        Me.tb_UID.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_table)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_tablename)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_foldername)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.tb_input)
        Me.GroupBox1.Controls.Add(Me.btn_open)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.tb_filename)
        Me.GroupBox1.Controls.Add(Me.bnt_clearall)
        Me.GroupBox1.Controls.Add(Me.tb_UID)
        Me.GroupBox1.Controls.Add(Me.cb_type)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 337)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Box"
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(441, 77)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(84, 23)
        Me.btn_open.TabIndex = 29
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(547, 77)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'cb_foldername
        '
        Me.cb_foldername.FormattingEnabled = True
        Me.cb_foldername.Items.AddRange(New Object() {"PRODUCT", "USER"})
        Me.cb_foldername.Location = New System.Drawing.Point(78, 102)
        Me.cb_foldername.Name = "cb_foldername"
        Me.cb_foldername.Size = New System.Drawing.Size(190, 21)
        Me.cb_foldername.TabIndex = 45
        '
        'lb_table
        '
        Me.lb_table.AutoSize = True
        Me.lb_table.Location = New System.Drawing.Point(5, 76)
        Me.lb_table.Name = "lb_table"
        Me.lb_table.Size = New System.Drawing.Size(65, 13)
        Me.lb_table.TabIndex = 47
        Me.lb_table.Text = "Table Name"
        '
        'tb_tablename
        '
        Me.tb_tablename.Location = New System.Drawing.Point(78, 76)
        Me.tb_tablename.Name = "tb_tablename"
        Me.tb_tablename.Size = New System.Drawing.Size(190, 20)
        Me.tb_tablename.TabIndex = 46
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 361)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents tb_input As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents cb_type As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bnt_clearall As Button
    Friend WithEvents tb_filename As TextBox
    Friend WithEvents tb_UID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents cb_foldername As ComboBox
    Friend WithEvents lb_table As Label
    Friend WithEvents tb_tablename As TextBox
End Class
