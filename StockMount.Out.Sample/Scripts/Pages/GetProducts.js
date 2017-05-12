var GetProducts = function () {
    return {
        //main function to initiate the module
        init: function () {
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {
                var getProductsCriteria = {
                    ProductId: $('#product').val().trim() == '' ? 0 : $('#product').val().trim(),
                    ProductSourceId: $('#product-source-id').val().trim() == '' ? 0 : $('#product-source-id').val().trim(),
                    ProductCode: $('#product-code').val(),
                    Keywords: $('#product-name').val(), 
                    ProductStatus: $('#product-status').val().trim() == '' ? 0 : $('#product-status').val().trim(),
                    PageIndex: $('#pageIndex').val().trim() == '' ? 1 : $('#pageIndex').val().trim(),
                    RowsByPage: $('#rowsByPage').val().trim() == '' ? 10 : $('#rowsByPage').val().trim() 
                };

                getProductsCriteria = JSON.stringify(getProductsCriteria, null, 2);

                $.ajax({
                    url: '/Service/GetProducts',    
                    data: { 'param': getProductsCriteria },
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
        }
    };
}();

 