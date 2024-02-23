// async function deleteVehicle(id)
// {
//     await fetch('http://localhost:8080/Vehicle/Delete/' + id, {
//         method: 'DELETE'
//     }).then(res => window.location.href = "http://localhost:8080/Vehicle/Index");
// }

async function updateVehicle(id) {
    await fetch('http://localhost:8080/Vehicle/Update/' + id, {
        method: 'PUT',
        body: FormData
    }).then(res => window.location.href = "http://localhost:8080/Vehicle/Index");
}