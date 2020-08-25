<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddCart = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdBooking = New System.Windows.Forms.TextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketingDatabaseDataSet = New WAP_Assignment.ticketingDatabaseDataSet()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPromotionCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSeatNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAdult = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.OrderTableAdapter = New WAP_Assignment.ticketingDatabaseDataSetTableAdapters.orderTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketingDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(662, 302)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 35)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(517, 302)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(113, 35)
        Me.btnRemove.TabIndex = 44
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(241, 362)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(786, 113)
        Me.ListView1.TabIndex = 34
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID booking"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 72
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Phone number"
        Me.ColumnHeader3.Width = 142
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Movie name"
        Me.ColumnHeader4.Width = 102
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Seat no"
        Me.ColumnHeader5.Width = 79
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Day"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Time"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Promotion code"
        Me.ColumnHeader8.Width = 129
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(803, 302)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 35)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddCart
        '
        Me.btnAddCart.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCart.Location = New System.Drawing.Point(368, 302)
        Me.btnAddCart.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddCart.Name = "btnAddCart"
        Me.btnAddCart.Size = New System.Drawing.Size(113, 35)
        Me.btnAddCart.TabIndex = 32
        Me.btnAddCart.Text = "Add cart"
        Me.btnAddCart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 543)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 543)
        Me.Panel3.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(3, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 55)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "Add Cart"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 54)
        Me.Panel1.TabIndex = 46
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Location = New System.Drawing.Point(568, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(182, 54)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Delete Movie"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(831, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(376, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 54)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Check Movie"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(188, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 54)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update Movie"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Create Movie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(596, 184)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Children"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(596, 155)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Student"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(596, 121)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Adult"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(577, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Please select:"
        '
        'txtIdBooking
        '
        Me.txtIdBooking.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "order_id", True))
        Me.txtIdBooking.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdBooking.Location = New System.Drawing.Point(413, 96)
        Me.txtIdBooking.Name = "txtIdBooking"
        Me.txtIdBooking.Size = New System.Drawing.Size(112, 24)
        Me.txtIdBooking.TabIndex = 108
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.TicketingDatabaseDataSet
        '
        'TicketingDatabaseDataSet
        '
        Me.TicketingDatabaseDataSet.DataSetName = "ticketingDatabaseDataSet"
        Me.TicketingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(413, 238)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 24)
        Me.DateTimePicker1.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Phone number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 100
        '
        'txtPromotionCode
        '
        Me.txtPromotionCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "promotion_code", True))
        Me.txtPromotionCode.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromotionCode.Location = New System.Drawing.Point(768, 246)
        Me.txtPromotionCode.Name = "txtPromotionCode"
        Me.txtPromotionCode.Size = New System.Drawing.Size(120, 24)
        Me.txtPromotionCode.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 240)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Date and Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "ID booking:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(589, 208)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Seat no:"
        '
        'txtSeatNo
        '
        Me.txtSeatNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "seat", True))
        Me.txtSeatNo.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatNo.Location = New System.Drawing.Point(768, 210)
        Me.txtSeatNo.Name = "txtSeatNo"
        Me.txtSeatNo.Size = New System.Drawing.Size(120, 24)
        Me.txtSeatNo.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(586, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Enter promotion code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Movie name:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "name", True))
        Me.txtName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(413, 130)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 24)
        Me.txtName.TabIndex = 107
        '
        'txtMovieName
        '
        Me.txtMovieName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "movie_name", True))
        Me.txtMovieName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieName.Location = New System.Drawing.Point(413, 206)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(112, 24)
        Me.txtMovieName.TabIndex = 105
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "phone_number", True))
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(413, 167)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(112, 24)
        Me.txtPhoneNumber.TabIndex = 106
        '
        'txtAdult
        '
        Me.txtAdult.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "adult_quantity", True))
        Me.txtAdult.Location = New System.Drawing.Point(803, 114)
        Me.txtAdult.Name = "txtAdult"
        Me.txtAdult.Size = New System.Drawing.Size(34, 23)
        Me.txtAdult.TabIndex = 130
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkOrange
        Me.Button9.Location = New System.Drawing.Point(834, 114)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 24)
        Me.Button9.TabIndex = 129
        Me.Button9.Text = "+"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.Location = New System.Drawing.Point(761, 113)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 25)
        Me.Button5.TabIndex = 128
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtStudent
        '
        Me.txtStudent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "student_quantity", True))
        Me.txtStudent.Location = New System.Drawing.Point(803, 145)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(34, 23)
        Me.txtStudent.TabIndex = 127
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkOrange
        Me.Button7.Location = New System.Drawing.Point(834, 145)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 24)
        Me.Button7.TabIndex = 126
        Me.Button7.Text = "+"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DarkOrange
        Me.Button11.Location = New System.Drawing.Point(761, 144)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(45, 25)
        Me.Button11.TabIndex = 125
        Me.Button11.Text = "-"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'txtChildren
        '
        Me.txtChildren.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "children_quantity", True))
        Me.txtChildren.Location = New System.Drawing.Point(803, 182)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(34, 23)
        Me.txtChildren.TabIndex = 124
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.DarkOrange
        Me.Button12.Location = New System.Drawing.Point(834, 181)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(47, 25)
        Me.Button12.TabIndex = 123
        Me.Button12.Text = "+"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.DarkOrange
        Me.Button13.Location = New System.Drawing.Point(761, 181)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(45, 25)
        Me.Button13.TabIndex = 122
        Me.Button13.Text = "-"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(1081, 543)
        Me.Controls.Add(Me.txtAdult)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.txtChildren)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdBooking)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPromotionCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSeatNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMovieName)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddCart)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "order"
        Me.Text = "order"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketingDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddCart As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdBooking As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPromotionCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSeatNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMovieName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAdult As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents txtChildren As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents TicketingDatabaseDataSet As ticketingDatabaseDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As ticketingDatabaseDataSetTableAdapters.orderTableAdapter
End Class
