Public Class RentalManager
    ReadOnly db As New Database()


    Public Sub ProcessPayment(session As UserSession, totalPrice As Double, costumerBooking As CostumerBooking)

        db.SubtractCreditToUser(session.UID, totalPrice)
        Dim updatedUser As UserTemplate = db.GetSpecificUser(session.UID)
        costumerBooking.UpdateCreditsLabel(updatedUser.Credits)

    End Sub
End Class
