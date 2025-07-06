Option Strict Off
Option Explicit On
Friend Class main_form
    Inherits System.Windows.Forms.Form
    Dim WithEvents Optimization1DX1 As optimal1dx.Optimization1DX
    Dim iteration As Short
    Dim stationary As Short
    Dim Length As Integer
    Dim u As Integer
    Private Sub cbStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles b_Start.Click
        b_Start.Enabled = False

        Optimization1DX1.NumberOfRepositoryPieces = 6
        Optimization1DX1.SetRepositoryPiece(0, 100, 0)
        Optimization1DX1.SetRepositoryPiece(1, 200, 1)
        Optimization1DX1.SetRepositoryPiece(2, 50, 2)
        Optimization1DX1.SetRepositoryPiece(3, 40, 3)
        Optimization1DX1.SetRepositoryPiece(4, 130, 4)
        Optimization1DX1.SetRepositoryPiece(5, 183, 5)

        Optimization1DX1.NumberOfDemandPieces = 10
        Optimization1DX1.BladeWidth = 0
        Optimization1DX1.OptimizationLevel = 50
        Optimization1DX1.Width = 10
        Optimization1DX1.RandomSeed = 0

        Optimization1DX1.SetDemandPiece(0, 141, 45, 45, 0)
        Optimization1DX1.SetDemandPiece(1, 41, 45, 45, 1)
        Optimization1DX1.SetDemandPiece(2, 49, 45, 45, 2)
        Optimization1DX1.SetDemandPiece(3, 142, 90, 45, 3)
        Optimization1DX1.SetDemandPiece(4, 78, 90, 45, 4)
        Optimization1DX1.SetDemandPiece(5, 61, 90, 45, 5)
        Optimization1DX1.SetDemandPiece(6, 65, 45, 90, 6)
        Optimization1DX1.SetDemandPiece(7, 78, 45, 45, 7)
        Optimization1DX1.SetDemandPiece(8, 61, 90, 45, 8)
        Optimization1DX1.SetDemandPiece(9, 65, 45, 90, 9)

        iteration = 0
        stationary = 0


        lbUsedPieces.Items.Clear()
        lbUnusedPieces.Items.Clear()

        Optimization1DX1.Start()
    End Sub
    Private Sub Optimization1DX1_OnFinish() Handles Optimization1DX1.OnFinish
        Dim index_bar As Long
        Dim index_piece As Long
        tbWaste.Text = CStr(Optimization1DX1.TotalWaste)

        Dim angle_1 As Double
        Dim angle_2 As Double
        Dim tmp As Double
        Dim demand_ID As Integer 'external ID of Demand
        Dim repository_ID As Integer 'external ID of Repository
        Dim demand_Index As Integer 'Index of Demand
        Dim repository_Index As Integer 'Index of Repository

        Dim utilized_bar_index As Integer

        For index_piece = 0 To Optimization1DX1.NumberOfDemandPieces - 1

            Optimization1DX1.DemandPieceUtilized(index_piece, utilized_bar_index, demand_ID, repository_Index, repository_ID)

            Optimization1DX1.GetDemandPiece(index_piece, Length, angle_1, angle_2, demand_ID)
            If utilized_bar_index >= 0 Then
                lbUsedPieces.Items.Add(CStr(Length))
            Else
                lbUnusedPieces.Items.Add(CStr(Length))
            End If
        Next index_piece

        lbCuttingOrder.Items.Clear()
        Dim rotatedOx As Integer ' 1 if Ox rotated
        Dim rotatedOy As Integer
        Dim rotatedOz As Integer
        Dim num_utilized As Integer ' number of utilised pieces in a particular bar


        Dim tmp_str As String

        Dim waste As Double
        For index_bar = 0 To Optimization1DX1.TotalNumberOfUtilizedRepositoryPieces - 1

            tmp_str = "Bar " & CStr(index_bar) & ": "

            Optimization1DX1.GetUtilizedDemandPiece(index_bar, 0, repository_Index, demand_Index, rotatedOx, rotatedOy, rotatedOz, repository_ID, demand_ID)

            Optimization1DX1.GetRepositoryPiece(repository_Index, Length, repository_ID)

            tmp_str = tmp_str & "(Length = " & CStr(Length) & ")"
            Optimization1DX1.GetNumberOfUtilizedDemandPieces(index_bar, num_utilized, repository_Index, repository_ID)
            For index_piece = 0 To num_utilized - 1
                Optimization1DX1.GetUtilizedDemandPiece(index_bar, index_piece, repository_Index, demand_Index, rotatedOx, rotatedOy, rotatedOz, repository_ID, demand_ID)
                Optimization1DX1.GetDemandPiece(demand_Index, Length, angle_1, angle_2, demand_ID)
                If rotatedOx = 1 Then
                    angle_1 = 180 - angle_1
                    angle_2 = 180 - angle_2
                End If
                If rotatedOy = 1 Then
                    tmp = angle_1
                    angle_1 = 180 - angle_2
                    angle_2 = 180 - tmp
                End If
                If rotatedOz = 1 Then
                    tmp = angle_1
                    angle_1 = angle_2
                    angle_2 = tmp
                End If
                tmp_str = tmp_str & "(" & CStr(Length) & "," & CStr(angle_1) & "," & CStr(angle_2) & ")"
            Next index_piece
            Optimization1DX1.GetWaste(index_bar, waste, repository_Index, repository_ID)
            tmp_str = tmp_str & "(Waste = " & CStr(waste) & ")"

            lbCuttingOrder.Items.Add(tmp_str)
        Next index_bar
        b_Start.Enabled = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Optimization1DX1 = New optimal1dx.Optimization1DX
        register_form.tbComputerID.Text = Optimization1DX1.ComputerID
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        register_form.tbComputerID.Text = Optimization1DX1.ComputerID
        If register_form.ShowDialog() = DialogResult.OK Then
            Optimization1DX1.UserName = register_form.tbName.Text
            Optimization1DX1.SerialNumber = register_form.tbSerialNumber.Text
            Optimization1DX1.RegisterOptimization1DX()
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about_form.l_version.Text = "CUT1DX Version " + Optimization1DX1.Version
        about_form.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class