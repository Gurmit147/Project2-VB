Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Dim order As String
    Dim number As String
    Dim price As Double
    Dim outPrice As String
    Dim payment As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Foodbtn.Click
        FoodPanel.Visible = True
        WaterPanel.Visible = False
        Stationeries.Visible = False
        Dailyneeds.Visible = False
        Receipt.Visible = False
        Cart.Visible = True
        cartItem.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Waterbtn.Click
        FoodPanel.Visible = False
        WaterPanel.Visible = True
        Stationeries.Visible = False
        Dailyneeds.Visible = False
        Receipt.Visible = False
        Cart.Visible = True
        cartItem.Visible = True
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Stationerybtn.Click
        FoodPanel.Visible = False
        WaterPanel.Visible = False
        Stationeries.Visible = True
        Dailyneeds.Visible = False
        Receipt.Visible = False
        Cart.Visible = True
        cartItem.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Dailyneedsbtn.Click
        FoodPanel.Visible = False
        WaterPanel.Visible = False
        Stationeries.Visible = False
        Dailyneeds.Visible = True
        Receipt.Visible = False
        Cart.Visible = True
        cartItem.Visible = True
    End Sub

    Private Sub btnBread_Click(sender As Object, e As EventArgs) Handles btnBread.Click

        If coBread.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Gardinier Bread"
            outPrice = (coBread.Text * 3.0).ToString
            number = coBread.Text.ToString
            price += coBread.Text * 3.0
            Dim items As String() = {order, coBread.Text, 3.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If


    End Sub



    Private Sub btnEggs_Click(sender As Object, e As EventArgs) Handles btnEggs.Click

        If coEggs.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Eggs"
            outPrice = (coEggs.Text * 0.5).ToString
            number = coEggs.Text.ToString
            price += coEggs.Text * 0.5

            Dim items As String() = {order, coEggs.Text, 0.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnMaggie_Click(sender As Object, e As EventArgs) Handles btnMaggie.Click

        If coMaggie.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Maggie Curry"
            outPrice = coMaggie.Text * 6.0.ToString
            number = coMaggie.Text.ToString
            price += coMaggie.Text * 6.0

            Dim items As String() = {order, coMaggie.Text, 6.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnMaggie2_Click(sender As Object, e As EventArgs) Handles btnMaggie2.Click

        If coMaggie2.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Maggie Spicy"
            outPrice = coMaggie2.Text * 7.0.ToString
            number = coMaggie2.Text.ToString
            price += coMaggie2.Text * 7.0

            Dim items As String() = {order, coMaggie2.Text, 7.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnOats_Click(sender As Object, e As EventArgs) Handles btnOats.Click

        If coOats.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Oats"
            outPrice = coOats.Text * 4.5.ToString
            number = coOats.Text.ToString
            price += coOats.Text * 4.5

            Dim items As String() = {order, coOats.Text, 4.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If


    End Sub

    Private Sub btnChips_Click(sender As Object, e As EventArgs) Handles btnChips.Click

        If coChips.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Chipsmore"
            outPrice = coChips.Text * 6.5.ToString
            number = coChips.Text.ToString
            price += coChips.Text * 6.5

            Dim items As String() = {order, coChips.Text, 6.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub Cart_Click(sender As Object, e As EventArgs) Handles Cart.Click
        FoodPanel.Visible = False
        WaterPanel.Visible = False
        Stationeries.Visible = False
        Dailyneeds.Visible = False
        Receipt.Visible = True
        Cart.Visible = False
        cartItem.Visible = False



    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnMWS.Click

        If coMWs.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Mineral Water(S)"
            outPrice = coMWs.Text * 1.0.ToString
            number = coMWs.Text.ToString
            price += coMWs.Text * 1.0

            Dim items As String() = {order, coMWs.Text, 1.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnMWL_Click(sender As Object, e As EventArgs) Handles btnMWL.Click

        If coMWL.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Mineral Water(L)"
            outPrice = coMWL.Text * 2.0.ToString
            number = coMWL.Text.ToString
            price += coMWL.Text * 2.0

            Dim items As String() = {order, coMWL.Text, 2.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click

        If coCoke.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Coca Cola"
            outPrice = coCoke.Text * 3.0.ToString
            number = coCoke.Text.ToString
            price += coCoke.Text * 3.0

            Dim items As String() = {order, coCoke.Text, 3.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnSprite_Click(sender As Object, e As EventArgs) Handles btnSprite.Click

        If coSprite.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Sprite"
            outPrice = coSprite.Text * 3.0.ToString
            number = coSprite.Text.ToString
            price += coSprite.Text * 3.0

            Dim items As String() = {order, coSprite.Text, 3.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click

        If coOrange.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "F&N Orange"
            outPrice = coOrange.Text * 4.5.ToString
            number = coOrange.Text.ToString
            price += coOrange.Text * 4.5

            Dim items As String() = {order, coOrange.Text, 4.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnSarsi_Click(sender As Object, e As EventArgs) Handles btnSarsi.Click

        If coSarsi.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "F&N Sarsi"
            outPrice = coSarsi.Text * 4.5.ToString
            number = coSarsi.Text.ToString
            price += coSarsi.Text * 4.5

            Dim items As String() = {order, coSarsi.Text, 4.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnSoap_Click(sender As Object, e As EventArgs) Handles btnSoap.Click

        If coSoap.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Soap"
            outPrice = coSoap.Text * 4.0.ToString
            number = coSoap.Text.ToString
            price += coSoap.Text * 4.0

            Dim items As String() = {order, coSoap.Text, 4.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnShampoo_Click(sender As Object, e As EventArgs) Handles btnShampoo.Click

        If coShampoo.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Shampoo"
            outPrice = coShampoo.Text * 12.0.ToString
            number = coShampoo.Text.ToString
            price += coShampoo.Text * 12.0

            Dim items As String() = {order, coShampoo.Text, 12.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnSlippers_Click(sender As Object, e As EventArgs) Handles btnSlippers.Click

        If coSlippers.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Slippers"
            outPrice = coSlippers.Text * 10.0.ToString
            number = coSlippers.Text.ToString
            price += coSlippers.Text * 10.0

            Dim items As String() = {order, coSlippers.Text, 10.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnMask_Click(sender As Object, e As EventArgs) Handles btnMask.Click

        If coMask.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Face Mask"
            outPrice = coMask.Text * 9.5.ToString
            number = coMask.Text.ToString
            price += coMask.Text * 9.5

            Dim items As String() = {order, coMask.Text, 9.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnPillow_Click(sender As Object, e As EventArgs) Handles btnPillow.Click

        If coPillow.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Pillow"
            outPrice = coPillow.Text * 15.0.ToString
            number = coPillow.Text.ToString
            price += coPillow.Text * 15.0

            Dim items As String() = {order, coPillow.Text, 15.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnFebreze_Click(sender As Object, e As EventArgs) Handles btnFebreze.Click

        If coFebreze.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Febreze"
            outPrice = coFebreze.Text * 13.0.ToString
            number = coFebreze.Text.ToString
            price += coFebreze.Text * 13.0

            Dim items As String() = {order, coFebreze.Text, 13.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnPencils_Click(sender As Object, e As EventArgs) Handles btnPencils.Click

        If coPencils.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Pencils 2B"
            outPrice = coPencils.Text * 1.5.ToString
            number = coPencils.Text.ToString
            price += coPencils.Text * 1.5

            Dim items As String() = {order, coPencils.Text, 1.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnBluePen_Click(sender As Object, e As EventArgs) Handles btnBluePen.Click

        If coBluePen.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Blue Pen"
            outPrice = coBluePen.Text * 2.0.ToString
            number = coBluePen.Text.ToString
            price += coBluePen.Text * 2.0

            Dim items As String() = {order, coBluePen.Text, 2.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnBlackPen_Click(sender As Object, e As EventArgs) Handles btnBlackPen.Click

        If coBlackPen.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Black Pen"
            outPrice = coBlackPen.Text * 2.0.ToString
            number = coBlackPen.Text.ToString
            price += coBlackPen.Text * 2.0

            Dim items As String() = {order, coBlackPen.Text, 2.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnRedPen_Click(sender As Object, e As EventArgs) Handles btnRedPen.Click

        If coRedPen.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Red Pen"
            outPrice = coRedPen.Text * 2.0.ToString
            number = coRedPen.Text.ToString
            price += coRedPen.Text * 2.0

            Dim items As String() = {order, coRedPen.Text, 2.0, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub btnCorrectionTape_Click(sender As Object, e As EventArgs) Handles btnCorrectionTape.Click

        If coCorrectionTape.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Correction Tape"
            outPrice = coCorrectionTape.Text * 3.5.ToString
            number = coCorrectionTape.Text.ToString
            price += coCorrectionTape.Text * 3.5

            Dim items As String() = {order, coCorrectionTape.Text, 3.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If coEraser.Text = "" Then
            MessageBox.Show("Please enter quantity")
        Else
            order = "Eraser"
            outPrice = coEraser.Text * 0.5.ToString
            number = coEraser.Text.ToString
            price += coEraser.Text * 0.5

            Dim items As String() = {order, coEraser.Text, 0.5, outPrice, "Delete"}
            totalReceipt.Rows.Add(items)
            cartItem.Text = totalReceipt.Rows.Count
        End If

    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click


        If rbtnCash.Checked Then
            payment = "Cash"
        ElseIf rbtnDuitNow.Checked Then
            payment = "Online"
        End If

        doc.DefaultPageSettings.PaperSize = New PaperSize("MySize", 250, 600)
        PrintPreviewDialog1.Document = doc
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 2.5
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles doc.PrintPage
        'set fonts
        Dim f8 = New Font("Arial", 8, FontStyle.Regular)
        Dim f8b = New Font("Verdana", 8, FontStyle.Bold)

        'set alignments
        Dim left As New StringFormat
        Dim center As New StringFormat
        Dim right As New StringFormat

        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        'draw rectangle
        Dim Rect1 As New Rectangle(5, 5, 240, 17)
        Dim Rect2 As New Rectangle(5, 22, 240, 17)
        Dim Rect3 As New Rectangle(5, 73, 60, 17)
        Dim Rect4 As New Rectangle(65, 73, 60, 17)
        Dim Rect5 As New Rectangle(125, 73, 60, 17)
        Dim Rect6 As New Rectangle(185, 73, 60, 17)




        e.Graphics.DrawRectangle(Pens.Black, Rect1)
        e.Graphics.DrawRectangle(Pens.Black, Rect2)
        e.Graphics.DrawRectangle(Pens.Black, Rect3)
        e.Graphics.DrawRectangle(Pens.Black, Rect4)
        e.Graphics.DrawRectangle(Pens.Black, Rect5)
        e.Graphics.DrawRectangle(Pens.Black, Rect6)


        e.Graphics.DrawString("Koperasi", f8, Brushes.Black, Rect1, center)
        e.Graphics.DrawString("Politeknik Seberang Perai", f8, Brushes.Black, Rect2, center)
        e.Graphics.DrawString("Items", f8, Brushes.Black, Rect3, center)
        e.Graphics.DrawString("QTY", f8, Brushes.Black, Rect4, center)
        e.Graphics.DrawString("Price", f8, Brushes.Black, Rect5, center)
        e.Graphics.DrawString("Total", f8, Brushes.Black, Rect6, center)

        ''
        Dim row As Integer = 0
        Dim total As Double = 0
        For i = 0 To totalReceipt.Rows.Count - 1
            Dim Rect7 As New Rectangle(5, 90 + row, 60, 27)
            Dim Rect8 As New Rectangle(65, 90 + row, 60, 27)
            Dim Rect9 As New Rectangle(125, 90 + row, 60, 27)
            Dim Rect10 As New Rectangle(185, 90 + row, 60, 27)

            e.Graphics.DrawRectangle(Pens.Black, Rect7)
            e.Graphics.DrawRectangle(Pens.Black, Rect8)
            e.Graphics.DrawRectangle(Pens.Black, Rect9)
            e.Graphics.DrawRectangle(Pens.Black, Rect10)

            e.Graphics.DrawString(totalReceipt.Rows(i).Cells(0).Value, f8, Brushes.Black, Rect7, center)
            e.Graphics.DrawString(totalReceipt.Rows(i).Cells(1).Value, f8, Brushes.Black, Rect8, center)
            e.Graphics.DrawString(totalReceipt.Rows(i).Cells(2).Value, f8, Brushes.Black, Rect9, center)
            e.Graphics.DrawString(totalReceipt.Rows(i).Cells(3).Value, f8, Brushes.Black, Rect10, center)



            row += 27
            total += totalReceipt.Rows(i).Cells(1).Value * totalReceipt.Rows(i).Cells(2).Value
        Next

        Dim Rect11 As New Rectangle(5, 90 + row, 240, 27)
        e.Graphics.DrawRectangle(Pens.Black, Rect11)
        e.Graphics.DrawString("Total Bill: RM " + total.ToString(), f8b, Brushes.Black, Rect11, center)

        Dim Rect12 As New Rectangle(5, 120 + row, 240, 27)
        e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString("Payment method: " + payment, f8b, Brushes.Black, Rect12, center)

        Dim Rect13 As New Rectangle(5, 150 + row, 240, 27)
        e.Graphics.DrawRectangle(Pens.Black, Rect13)
        e.Graphics.DrawString("Thank you, Please come again", f8b, Brushes.Black, Rect13, center)

    End Sub

    Private Sub totalReceipt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles totalReceipt.CellContentClick
        Dim mycell As Integer
        mycell = totalReceipt.CurrentCell.RowIndex
        totalReceipt.Rows.RemoveAt(mycell)
        totalReceipt.Refresh()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        FoodPanel.Visible = True
        WaterPanel.Visible = False
        Stationeries.Visible = False
        Dailyneeds.Visible = False
        Receipt.Visible = False
        Cart.Visible = True
        cartItem.Visible = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Double
        For i = 0 To totalReceipt.Rows.Count - 1
            total += totalReceipt.Rows(i).Cells(1).Value * totalReceipt.Rows(i).Cells(2).Value
        Next
        dispTotal.Text = "Total : RM " + total.ToString()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Me.Close()
        Form5.Show()
    End Sub
End Class