var UpdateProduct = function () {
    return {
        //main function to initiate the module
        init: function () {

            $('.add-row').off('click').click(function () {
                var newRow = $(this).closest('table').find('tbody tr:first').clone();
                $(newRow).removeClass('display-none');
                $(newRow).addClass('new-row');

                $(this).closest('table').find('tbody').append(newRow);
                AddProduct.init();

            });
            
            $('.remove-row').off('click').click(function () {
                $(this).closest('tr').remove();
               


            });
            $('#btn-test').off('click').click(function () {
                $('#test-area').show('blind');
            });

            $('#btn-execute').off('click').click(function () {

                var product = {
                    ProductId :$('#product-id').val().trim() == '' ? '-1':  $('#product-id').val(),
                    ProductSourceId: $('#product-source-id').val().trim() == '' ? '0' : $('#product-source-id').val(),
                    Code: $('#code').val(),
                    Barcode: $('#barcode').val(),
                    Name: $('#name').val(),
                    Subtitle: $('#subtitle').val(),
                    Price: $('#price').val().trim() == '' ? '0' : $('#price').val(),
                    Quantity: $('#quantity').val().trim() == '' ? '0' : $('#quantity').val(),
                    Brand: $('#brand').val(),
                    TaxRate: $('#taxrate').val().trim() == '' ? '0' : $('#taxrate').val(),
                    Model: $('#model').val(),
                    Category: $('#category').val(),
                    CurrencyId: $('#currency').val().trim() == '' ? '0' : $('#currency').val(),
                    MarketPrice: $('#marketprice').val().trim() == '' ? '0' : $('#marketprice').val(),
                    Volume: $('#volume').val().trim() == '' ? '0' : $('#volume').val(),
                    Height: $('#height').val().trim() == '' ? '0' : $('#height').val(),
                    Length: $('#length').val().trim() == '' ? '0' : $('#length').val(),
                    Width: $('#width').val().trim() == '' ? '0' : $('#width').val(),
                    VariantName1: $('#variantname1').val(),
                    VariantName2: $('#variantname2').val(),
                    VariantName3: $('#variantname3').val(),
                    VariantName4: $('#variantname4').val(),
                    Images: [],
                    Specs: [],
                    Variants: []
                };

                var imagesRows = $('#images').find('tbody tr.new-row');
                $.each(imagesRows, function (i, row) {
                    if ($(row).find('.input-url').val().trim() != '') {
                        product.Images.push({
                            Order: product.Images.length,
                            Url: $(row).find('.input-url').val()
                        });
                    }

                });
                
                var specsRows = $('#specs').find('tbody tr.new-row');
                $.each(specsRows, function (i, row) {
                    if ($(row).find('.input-name').val().trim() != '' && $(row).find('.input-value').val().trim() != '') {
                        product.Specs.push({
                            Name: $(row).find('.input-name').val(),
                            Value: $(row).find('.input-value').val()
                        });
                    }

                });
                
                var variantsRows = $('#variants').find('tbody tr.new-row');
                $.each(variantsRows, function (i, row) {
                    product.Variants.push({
                        
                        Code: $(row).find('.input-code').val(),
                        Price: $(row).find('.input-price').val().trim() == '' ? '0' : $(row).find('.input-price').val(),
                        Quantity: $(row).find('.input-quantity').val().trim() == '' ? '0' : $(row).find('.input-quantity').val(),
                        Barcode: $(row).find('.input-barcode').val(),
                        CurrencyId: $(row).find('.input-currencyid').val().trim() == '' ? '0' : $(row).find('.input-currencyid').val(),
                        ImageUrl: $(row).find('.input-image-url').val(),
                        VariantValue1: $(row).find('.input-variant-value1').val(),
                        VariantValue2: $(row).find('.input-variant-value2').val(),
                        VariantValue3: $(row).find('.input-variant-value3').val(),
                        VariantValue4: $(row).find('.input-variant-value4').val()

                    });

                });
                
                product = JSON.stringify(product, null, 2);

                $.ajax({
                    url: '/Service/UpdateProduct',
                    data: { 'param': product },
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