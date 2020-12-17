$(document).ready(function () {
    $('.product_cart_button').click(function () {
        var id = this.getAttribute('cid');
        $.ajax({
            url: '/Cart/AjaxAdd',
            method: 'POST',
            data: {
                id: id,
            },
            success: function (result) {
                if (result != null) {
                    alert("Đã thêm vào giỏ hàng");

                    var quantity = 0;
                    var price = 0;
                    var obj = jQuery.parseJSON(result);
                    obj.forEach(function (item) {
                        quantity += item.Quantity;
                        price += item.Price * quantity;
                    });
                    //₫
                    $('.cart_count span').text(quantity);
                    $('.cart_price').text(price.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1.") + " ₫");
                }
                else {
                    alert("Đã có trong giỏ hàng");
                }
            } 
        })
    });
});