$(document).ready(function () {
    $('#createForm').on('submit', function (event) {
        event.preventDefault(); 

        var formData = new FormData(this);

        $.ajax({
            url: '/Clientes/Create',
            type: 'POST',
            data: formData,
            processData: false, 
            contentType: false, 
            success: function (response) {
                window.location.href = '/Clientes/Index';
            },
            error: function (xhr, status, error) {
                console.error(xhr.responseText);
                alert('Erro ao criar o cliente. Verifique o console para mais detalhes.');
            }
        });
    });
});
