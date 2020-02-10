$(document).ready(function () {
    $("#Date").datepicker({
        showAnim: "bounce",
        changeYear: true,
        changeYear: true
    });

    $("#addOrderBtn").click(function () {

        if ($("#ProductId").val() == "" || $("#Qty").val() == 0 ||
            $("#UnitPrice").val() == 0 || $("#DiscountPercenteg").val() == 0) {
            alert("Insert Order Details");
        }
        else {
            var product = $("#ProductId").val();
            var qty = $("#Qty").val();
            var unitPrice = $("#UnitPrice").val();
            var discountPercenteg = $("#DiscountPercenteg").val();

            $("#orderDetails").append('<tr><td>' + product + '</td><td>' + qty + '</td><td>' + unitPrice + '</td><td>' + discountPercenteg + '</td></tr>');

            $("#ProductId").val("");
            $("#Qty").val("");
            $("#UnitPrice").val("");
            $("#DiscountPercenteg").val("");
        }
        
    });
});