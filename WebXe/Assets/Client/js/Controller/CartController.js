var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/ProductClient/Index";
        });

        $('#updatecart').off('click').on('click', function () {
            var listProduct = $('.txtqty');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                cartList.push({
                    Qty: $(item).val(),
                    Product: {
                        id: $(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/CartClient/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/CartClient/Index";
                    }
                }
            });
        });

        $('#btnDeleteAll').off('click').on('click', function () {
            $.ajax({
                url: '/CartClient/DeleteAll',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/CartClient/Index";
                    }
                }
            });
        });

        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: { id: $(this).data('id') },
                url: '/CartClient/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/CartClient/Index";
                    }
                }
            });
        });

        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/CartClient/Payment";
        });
    }
}
cart.init();