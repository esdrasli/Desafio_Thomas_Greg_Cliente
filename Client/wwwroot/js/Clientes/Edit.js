$(document).ready(function () {
    $('#editForm').on('submit', function (event) {
        event.preventDefault(); 

        var id = $(this).data('id'); 
        var formData = $(this).serialize(); 

        $.ajax({
            url: '/Clientes/Edit/' + id, 
            type: 'POST',
            data: formData,
            success: function (response) {
                window.location.href = '/Clientes/Index';
            },
            error: function (xhr, status, error) {
                console.error(xhr.responseText);
                alert('Erro ao atualizar o cliente. Verifique o console para mais detalhes.');
            }
        });
    });
});
