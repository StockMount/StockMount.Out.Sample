var GetSales = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var getSaleCriteria = {
                    StoreId: $('#store').val(),
                    OrderStatus: $('#orderStatus').val() 
                };

            if ($('#smallestOrderDetailId').val() != '') {
                getSaleCriteria.SmallestOrderDetailId = $('#smallestOrderDetailId').val();
            }

            if ($('#biggestOrderDetailId').val() != '') {
                getSaleCriteria.BiggestOrderDetailId = $('#biggestOrderDetailId').val();
            }

                getSaleCriteria = JSON.stringify(getSaleCriteria, null, 2);

                $.ajax({
                    url: '/Service/GetSales',
                    data: { 'param': getSaleCriteria },
                    success: function (data) {

                        var formatter = new JSONFormatter(data.Result, true);
                        $('#response-area').html(formatter.render());
                        $('#response-area').show('blind');
                    },
                    error: function (data) {


                    },
                    dataType: 'json'
                });
            });


            $('#order-status').off('click').click(function () {
                $('#status-area').show('blind');
            });
             
        }
    };
}();