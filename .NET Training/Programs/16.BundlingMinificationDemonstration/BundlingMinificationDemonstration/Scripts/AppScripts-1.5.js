
//This Function sends Ajax Request to the Server to get List of Employees...
function LoadEmployees() {
    alert("Welcome to AppScripts-1.5.js");
    $.ajax({
        type: 'GET',
        url: '/Home/GetEmployees',
        success: function (result) {
            //This function will be executed on a successful response from the server
            $.each(result, function (i, emp) {
                $("#empData").append('<tr><td>' + emp.Id +
                    '</td><td>' + emp.Name + '</td><td>' + emp.Location + '</td><td>' +
                    emp.Salary + '</td><td>' + emp.DeptId + '</td></td>');
            });
        }
    });
}

//This function gets the Employee Details By Employee ID
function GetByEmployeeId() {
    //Checking the Conformation before sending the request to the Server...
    var isReady = confirm('Are you sure to submit the request?');

    if (isReady) {
        $.ajax({
            type: 'GET',
            url: '/Home/GetEmployeeById/' + $("#empId").val(),
            success: function (output) {
                alert(JSON.stringify(output));
            }
        });
    }
}