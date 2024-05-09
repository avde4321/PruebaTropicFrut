function listEmpleado() {

    $.ajax({
        url: '/Empleados/listaEmpleado/',
        type: 'GET',
        dataType: "html",
        async: false,
        data: {

        },
        success: function (data) {
            $('#TblEmpleado').html(data);
        },
        error: function (data) {
            alert(data);
        }
    });
}

listEmpleado()

function ModalDepartamento(codDepto, nombreDpto, ciudad, codDirector) {

    $('#ModalDepartamento').show();

    $('#txtcodDepto').val(codDepto);
    $('#txtnombreDpto').val(nombreDpto);
    $('#txtciudad').val(ciudad);
    $('#txtcodDirector').val(codDirector);

}

function ClosuModal() {
    $('#ModalDepartamento').hide();
}