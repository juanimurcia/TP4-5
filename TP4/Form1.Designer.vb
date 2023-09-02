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
        Me.TDesde = New System.Windows.Forms.TextBox()
        Me.THasta = New System.Windows.Forms.TextBox()
        Me.BFuncion = New System.Windows.Forms.Button()
        Me.BPares = New System.Windows.Forms.Button()
        Me.BImpares = New System.Windows.Forms.Button()
        Me.BPrimos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TDesde
        '
        Me.TDesde.Location = New System.Drawing.Point(146, 70)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(127, 22)
        Me.TDesde.TabIndex = 0
        '
        'THasta
        '
        Me.THasta.Location = New System.Drawing.Point(146, 130)
        Me.THasta.Name = "THasta"
        Me.THasta.Size = New System.Drawing.Size(127, 22)
        Me.THasta.TabIndex = 1
        '
        'BFuncion
        '
        Me.BFuncion.Location = New System.Drawing.Point(146, 194)
        Me.BFuncion.Name = "BFuncion"
        Me.BFuncion.Size = New System.Drawing.Size(127, 23)
        Me.BFuncion.TabIndex = 3
        Me.BFuncion.Text = "Generar Función"
        Me.BFuncion.UseVisualStyleBackColor = True
        '
        'BPares
        '
        Me.BPares.Location = New System.Drawing.Point(144, 258)
        Me.BPares.Name = "BPares"
        Me.BPares.Size = New System.Drawing.Size(128, 23)
        Me.BPares.TabIndex = 4
        Me.BPares.Text = "Números Pares"
        Me.BPares.UseVisualStyleBackColor = True
        '
        'BImpares
        '
        Me.BImpares.Location = New System.Drawing.Point(144, 308)
        Me.BImpares.Name = "BImpares"
        Me.BImpares.Size = New System.Drawing.Size(128, 23)
        Me.BImpares.TabIndex = 5
        Me.BImpares.Text = "Números Impares"
        Me.BImpares.UseVisualStyleBackColor = True
        '
        'BPrimos
        '
        Me.BPrimos.Location = New System.Drawing.Point(144, 356)
        Me.BPrimos.Name = "BPrimos"
        Me.BPrimos.Size = New System.Drawing.Size(128, 23)
        Me.BPrimos.TabIndex = 6
        Me.BPrimos.Text = "Números Primos"
        Me.BPrimos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hasta"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(376, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(325, 340)
        Me.ListBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BPrimos)
        Me.Controls.Add(Me.BImpares)
        Me.Controls.Add(Me.BPares)
        Me.Controls.Add(Me.BFuncion)
        Me.Controls.Add(Me.THasta)
        Me.Controls.Add(Me.TDesde)
        Me.Name = "Form1"
        Me.Text = "Formulario 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TDesde As TextBox
    Friend WithEvents THasta As TextBox
    Friend WithEvents BFuncion As Button
    Friend WithEvents BPares As Button
    Friend WithEvents BImpares As Button
    Friend WithEvents BPrimos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
