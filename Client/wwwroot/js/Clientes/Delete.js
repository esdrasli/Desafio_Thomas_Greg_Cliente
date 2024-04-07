$(document).ready(function () {
    $('#btnDelete').on('click', function () {
        var id = $(this).data('id'); 

        if (confirm('Tem certeza de que deseja excluir este cliente?')) {
            $.ajax({
                url: '/Clientes/Delete/' + id, 
                type: 'POST',
                success: function (response) {
                    window.location.href = '/Clientes/Index';
                },
                error: function (xhr, status, error) {
                    console.error(xhr.responseText);
                    alert('Erro ao excluir o cliente. Verifique o console para mais detalhes.');
                }
            });
        }
    });
});
