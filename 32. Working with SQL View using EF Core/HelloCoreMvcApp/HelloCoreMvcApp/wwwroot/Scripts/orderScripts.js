var Id = 0;

$(document).ready(function () {
    $("#Date").datepicker({
        showAnim: "bounce",
        changeYear: true,
        changeYear: true
    });

    $("#addOrderBtn").click(function () {    
        var productId = $("#ProductId").val();
        var productName = $("#ProductId option:selected").text();
        var qty = $("#Qty").val();
        var unitPrice = $("#UnitPrice").val();
        var discountPercenteg = $("#DiscountPercenteg").val();

        $("#orderDetails").append('<tr><td> <input type="hidden" name="OrderDetails[' + Id + '].ProductId" value="' + productId + '"/>' + productName
            + '</td><td> <input type="hidden" name="OrderDetails[' + Id + '].Qty" value="' + qty + '"/>' + qty
            + '</td><td> <input type="hidden" name="OrderDetails[' + Id + '].UnitPrice" value="' + unitPrice + '"/>' + unitPrice
            + '</td><td> <input type="hidden" name="OrderDetails[' + Id + '].DiscountPercenteg" value="' + discountPercenteg + '"/>' + discountPercenteg + '</td></tr>');

        Id++;
    });
});