<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class debugForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tb_cmd = New System.Windows.Forms.TextBox()
        Me.tb_isConnected = New System.Windows.Forms.TextBox()
        Me.tb_fn = New System.Windows.Forms.TextBox()
        Me.tb_connectionstring = New System.Windows.Forms.TextBox()
        Me.tb_con = New System.Windows.Forms.TextBox()
        Me.tb_data = New System.Windows.Forms.TextBox()
        Me.tb_path = New System.Windows.Forms.TextBox()
        Me.lb_cmd = New System.Windows.Forms.Label()
        Me.lb_con = New System.Windows.Forms.Label()
        Me.lb_connectionString = New System.Windows.Forms.Label()
        Me.lb_fn = New System.Windows.Forms.Label()
        Me.lb_isConnected = New System.Windows.Forms.Label()
        Me.lb_path = New System.Windows.Forms.Label()
        Me.lb_Data = New System.Windows.Forms.Label()
        Me.cb_filename = New System.Windows.Forms.ComboBox()
        Me.lb_tablename = New System.Windows.Forms.Label()
        Me.lb_foldername = New System.Windows.Forms.Label()
        Me.lb_filename = New System.Windows.Forms.Label()
        Me.tb_tablename = New System.Windows.Forms.TextBox()
        Me.lb_UID = New System.Windows.Forms.Label()
        Me.cb_foldername = New System.Windows.Forms.ComboBox()
        Me.tb_UID = New System.Windows.Forms.TextBox()
        Me.cb_type = New System.Windows.Forms.ComboBox()
        Me.lb_type = New System.Windows.Forms.Label()
        Me.tb_val = New System.Windows.Forms.TextBox()
        Me.lb_val = New System.Windows.Forms.Label()
        Me.cb_columname = New System.Windows.Forms.ComboBox()
        Me.lb_delete = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.bnt_clearall = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.cb_list = New System.Windows.Forms.ComboBox()
        Me.lb_list = New System.Windows.Forms.Label()
        Me.tb_info = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_cmd
        '
        Me.tb_cmd.Location = New System.Drawing.Point(111, 15)
        Me.tb_cmd.Multiline = True
        Me.tb_cmd.Name = "tb_cmd"
        Me.tb_cmd.Size = New System.Drawing.Size(275, 20)
        Me.tb_cmd.TabIndex = 0
        '
        'tb_isConnected
        '
        Me.tb_isConnected.Location = New System.Drawing.Point(111, 119)
        Me.tb_isConnected.Name = "tb_isConnected"
        Me.tb_isConnected.Size = New System.Drawing.Size(275, 20)
        Me.tb_isConnected.TabIndex = 1
        '
        'tb_fn
        '
        Me.tb_fn.Location = New System.Drawing.Point(111, 93)
        Me.tb_fn.Name = "tb_fn"
        Me.tb_fn.Size = New System.Drawing.Size(275, 20)
        Me.tb_fn.TabIndex = 2
        '
        'tb_connectionstring
        '
        Me.tb_connectionstring.Location = New System.Drawing.Point(111, 67)
        Me.tb_connectionstring.Name = "tb_connectionstring"
        Me.tb_connectionstring.Size = New System.Drawing.Size(275, 20)
        Me.tb_connectionstring.TabIndex = 3
        '
        'tb_con
        '
        Me.tb_con.Location = New System.Drawing.Point(111, 41)
        Me.tb_con.Multiline = True
        Me.tb_con.Name = "tb_con"
        Me.tb_con.Size = New System.Drawing.Size(275, 20)
        Me.tb_con.TabIndex = 4
        '
        'tb_data
        '
        Me.tb_data.Location = New System.Drawing.Point(111, 171)
        Me.tb_data.Name = "tb_data"
        Me.tb_data.Size = New System.Drawing.Size(275, 20)
        Me.tb_data.TabIndex = 6
        '
        'tb_path
        '
        Me.tb_path.Location = New System.Drawing.Point(111, 145)
        Me.tb_path.Name = "tb_path"
        Me.tb_path.Size = New System.Drawing.Size(275, 20)
        Me.tb_path.TabIndex = 7
        '
        'lb_cmd
        '
        Me.lb_cmd.AutoSize = True
        Me.lb_cmd.Location = New System.Drawing.Point(13, 18)
        Me.lb_cmd.Name = "lb_cmd"
        Me.lb_cmd.Size = New System.Drawing.Size(33, 13)
        Me.lb_cmd.TabIndex = 8
        Me.lb_cmd.Text = "_cmd"
        '
        'lb_con
        '
        Me.lb_con.AutoSize = True
        Me.lb_con.Location = New System.Drawing.Point(13, 44)
        Me.lb_con.Name = "lb_con"
        Me.lb_con.Size = New System.Drawing.Size(31, 13)
        Me.lb_con.TabIndex = 9
        Me.lb_con.Text = "_con"
        '
        'lb_connectionString
        '
        Me.lb_connectionString.AutoSize = True
        Me.lb_connectionString.Location = New System.Drawing.Point(13, 70)
        Me.lb_connectionString.Name = "lb_connectionString"
        Me.lb_connectionString.Size = New System.Drawing.Size(93, 13)
        Me.lb_connectionString.TabIndex = 10
        Me.lb_connectionString.Text = "_connectionString"
        '
        'lb_fn
        '
        Me.lb_fn.AutoSize = True
        Me.lb_fn.Location = New System.Drawing.Point(13, 96)
        Me.lb_fn.Name = "lb_fn"
        Me.lb_fn.Size = New System.Drawing.Size(22, 13)
        Me.lb_fn.TabIndex = 11
        Me.lb_fn.Text = "_fn"
        '
        'lb_isConnected
        '
        Me.lb_isConnected.AutoSize = True
        Me.lb_isConnected.Location = New System.Drawing.Point(13, 122)
        Me.lb_isConnected.Name = "lb_isConnected"
        Me.lb_isConnected.Size = New System.Drawing.Size(72, 13)
        Me.lb_isConnected.TabIndex = 12
        Me.lb_isConnected.Text = "_isConnected"
        '
        'lb_path
        '
        Me.lb_path.AutoSize = True
        Me.lb_path.Location = New System.Drawing.Point(13, 148)
        Me.lb_path.Name = "lb_path"
        Me.lb_path.Size = New System.Drawing.Size(34, 13)
        Me.lb_path.TabIndex = 13
        Me.lb_path.Text = "_path"
        '
        'lb_Data
        '
        Me.lb_Data.AutoSize = True
        Me.lb_Data.Location = New System.Drawing.Point(13, 174)
        Me.lb_Data.Name = "lb_Data"
        Me.lb_Data.Size = New System.Drawing.Size(30, 13)
        Me.lb_Data.TabIndex = 14
        Me.lb_Data.Text = "Data"
        '
        'cb_filename
        '
        Me.cb_filename.FormattingEnabled = True
        Me.cb_filename.Location = New System.Drawing.Point(474, 67)
        Me.cb_filename.Name = "cb_filename"
        Me.cb_filename.Size = New System.Drawing.Size(100, 21)
        Me.cb_filename.TabIndex = 60
        '
        'lb_tablename
        '
        Me.lb_tablename.AutoSize = True
        Me.lb_tablename.Location = New System.Drawing.Point(401, 96)
        Me.lb_tablename.Name = "lb_tablename"
        Me.lb_tablename.Size = New System.Drawing.Size(65, 13)
        Me.lb_tablename.TabIndex = 59
        Me.lb_tablename.Text = "Table Name"
        '
        'lb_foldername
        '
        Me.lb_foldername.AutoSize = True
        Me.lb_foldername.Location = New System.Drawing.Point(401, 44)
        Me.lb_foldername.Name = "lb_foldername"
        Me.lb_foldername.Size = New System.Drawing.Size(67, 13)
        Me.lb_foldername.TabIndex = 54
        Me.lb_foldername.Text = "Folder Name"
        '
        'lb_filename
        '
        Me.lb_filename.AutoSize = True
        Me.lb_filename.Location = New System.Drawing.Point(401, 70)
        Me.lb_filename.Name = "lb_filename"
        Me.lb_filename.Size = New System.Drawing.Size(54, 13)
        Me.lb_filename.TabIndex = 53
        Me.lb_filename.Text = "File Name"
        '
        'tb_tablename
        '
        Me.tb_tablename.Location = New System.Drawing.Point(474, 93)
        Me.tb_tablename.Name = "tb_tablename"
        Me.tb_tablename.Size = New System.Drawing.Size(100, 20)
        Me.tb_tablename.TabIndex = 58
        '
        'lb_UID
        '
        Me.lb_UID.AutoSize = True
        Me.lb_UID.Location = New System.Drawing.Point(401, 18)
        Me.lb_UID.Name = "lb_UID"
        Me.lb_UID.Size = New System.Drawing.Size(26, 13)
        Me.lb_UID.TabIndex = 52
        Me.lb_UID.Text = "UID"
        '
        'cb_foldername
        '
        Me.cb_foldername.FormattingEnabled = True
        Me.cb_foldername.Location = New System.Drawing.Point(474, 41)
        Me.cb_foldername.Name = "cb_foldername"
        Me.cb_foldername.Size = New System.Drawing.Size(100, 21)
        Me.cb_foldername.TabIndex = 57
        '
        'tb_UID
        '
        Me.tb_UID.Location = New System.Drawing.Point(474, 15)
        Me.tb_UID.Name = "tb_UID"
        Me.tb_UID.Size = New System.Drawing.Size(100, 20)
        Me.tb_UID.TabIndex = 51
        '
        'cb_type
        '
        Me.cb_type.FormattingEnabled = True
        Me.cb_type.Items.AddRange(New Object() {"-SQLite", "-Access"})
        Me.cb_type.Location = New System.Drawing.Point(474, 119)
        Me.cb_type.Name = "cb_type"
        Me.cb_type.Size = New System.Drawing.Size(100, 21)
        Me.cb_type.TabIndex = 56
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Location = New System.Drawing.Point(401, 122)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(31, 13)
        Me.lb_type.TabIndex = 55
        Me.lb_type.Text = "Type"
        '
        'tb_val
        '
        Me.tb_val.Location = New System.Drawing.Point(474, 171)
        Me.tb_val.Name = "tb_val"
        Me.tb_val.Size = New System.Drawing.Size(100, 20)
        Me.tb_val.TabIndex = 70
        '
        'lb_val
        '
        Me.lb_val.AutoSize = True
        Me.lb_val.Location = New System.Drawing.Point(401, 174)
        Me.lb_val.Name = "lb_val"
        Me.lb_val.Size = New System.Drawing.Size(22, 13)
        Me.lb_val.TabIndex = 69
        Me.lb_val.Text = "Val"
        '
        'cb_columname
        '
        Me.cb_columname.FormattingEnabled = True
        Me.cb_columname.Location = New System.Drawing.Point(474, 145)
        Me.cb_columname.Name = "cb_columname"
        Me.cb_columname.Size = New System.Drawing.Size(100, 21)
        Me.cb_columname.TabIndex = 68
        '
        'lb_delete
        '
        Me.lb_delete.AutoSize = True
        Me.lb_delete.Location = New System.Drawing.Point(401, 148)
        Me.lb_delete.Name = "lb_delete"
        Me.lb_delete.Size = New System.Drawing.Size(36, 13)
        Me.lb_delete.TabIndex = 67
        Me.lb_delete.Text = "param"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(696, 42)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 63
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(590, 42)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(84, 23)
        Me.btn_open.TabIndex = 62
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(590, 71)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 23)
        Me.btn_update.TabIndex = 66
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'bnt_clearall
        '
        Me.bnt_clearall.Location = New System.Drawing.Point(696, 71)
        Me.bnt_clearall.Name = "bnt_clearall"
        Me.bnt_clearall.Size = New System.Drawing.Size(84, 23)
        Me.bnt_clearall.TabIndex = 61
        Me.bnt_clearall.Text = "Clear All"
        Me.bnt_clearall.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(696, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(84, 23)
        Me.btn_refresh.TabIndex = 65
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(590, 13)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 23)
        Me.btn_delete.TabIndex = 64
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(12, 209)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(767, 150)
        Me.DataGridViewTable.TabIndex = 71
        '
        'cb_list
        '
        Me.cb_list.FormattingEnabled = True
        Me.cb_list.Items.AddRange(New Object() {"all"})
        Me.cb_list.Location = New System.Drawing.Point(624, 100)
        Me.cb_list.Name = "cb_list"
        Me.cb_list.Size = New System.Drawing.Size(156, 21)
        Me.cb_list.TabIndex = 73
        '
        'lb_list
        '
        Me.lb_list.AutoSize = True
        Me.lb_list.Location = New System.Drawing.Point(592, 103)
        Me.lb_list.Name = "lb_list"
        Me.lb_list.Size = New System.Drawing.Size(31, 13)
        Me.lb_list.TabIndex = 72
        Me.lb_list.Text = "dblist"
        '
        'tb_info
        '
        Me.tb_info.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_info.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_info.ForeColor = System.Drawing.Color.Red
        Me.tb_info.Location = New System.Drawing.Point(595, 127)
        Me.tb_info.Multiline = True
        Me.tb_info.Name = "tb_info"
        Me.tb_info.Size = New System.Drawing.Size(184, 64)
        Me.tb_info.TabIndex = 74
        '
        'debugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 371)
        Me.Controls.Add(Me.tb_info)
        Me.Controls.Add(Me.cb_list)
        Me.Controls.Add(Me.lb_list)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Controls.Add(Me.tb_val)
        Me.Controls.Add(Me.lb_val)
        Me.Controls.Add(Me.cb_columname)
        Me.Controls.Add(Me.lb_delete)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.bnt_clearall)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.cb_filename)
        Me.Controls.Add(Me.lb_tablename)
        Me.Controls.Add(Me.lb_foldername)
        Me.Controls.Add(Me.lb_filename)
        Me.Controls.Add(Me.tb_tablename)
        Me.Controls.Add(Me.lb_UID)
        Me.Controls.Add(Me.cb_foldername)
        Me.Controls.Add(Me.tb_UID)
        Me.Controls.Add(Me.cb_type)
        Me.Controls.Add(Me.lb_type)
        Me.Controls.Add(Me.lb_Data)
        Me.Controls.Add(Me.lb_path)
        Me.Controls.Add(Me.lb_isConnected)
        Me.Controls.Add(Me.lb_fn)
        Me.Controls.Add(Me.lb_connectionString)
        Me.Controls.Add(Me.lb_con)
        Me.Controls.Add(Me.lb_cmd)
        Me.Controls.Add(Me.tb_path)
        Me.Controls.Add(Me.tb_data)
        Me.Controls.Add(Me.tb_con)
        Me.Controls.Add(Me.tb_connectionstring)
        Me.Controls.Add(Me.tb_fn)
        Me.Controls.Add(Me.tb_isConnected)
        Me.Controls.Add(Me.tb_cmd)
        Me.Name = "debugForm"
        Me.Text = "debugForm"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_cmd As TextBox
    Friend WithEvents tb_isConnected As TextBox
    Friend WithEvents tb_fn As TextBox
    Friend WithEvents tb_connectionstring As TextBox
    Friend WithEvents tb_con As TextBox
    Friend WithEvents tb_data As TextBox
    Friend WithEvents tb_path As TextBox
    Friend WithEvents lb_cmd As Label
    Friend WithEvents lb_con As Label
    Friend WithEvents lb_connectionString As Label
    Friend WithEvents lb_fn As Label
    Friend WithEvents lb_isConnected As Label
    Friend WithEvents lb_path As Label
    Friend WithEvents lb_Data As Label
    Friend WithEvents cb_filename As ComboBox
    Friend WithEvents lb_tablename As Label
    Friend WithEvents lb_foldername As Label
    Friend WithEvents lb_filename As Label
    Friend WithEvents tb_tablename As TextBox
    Friend WithEvents lb_UID As Label
    Friend WithEvents cb_foldername As ComboBox
    Friend WithEvents tb_UID As TextBox
    Friend WithEvents cb_type As ComboBox
    Friend WithEvents lb_type As Label
    Friend WithEvents tb_val As TextBox
    Friend WithEvents lb_val As Label
    Friend WithEvents cb_columname As ComboBox
    Friend WithEvents lb_delete As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents bnt_clearall As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents cb_list As ComboBox
    Friend WithEvents lb_list As Label
    Friend WithEvents tb_info As TextBox
End Class
