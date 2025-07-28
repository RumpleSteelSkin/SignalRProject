var connection = new signalR.HubConnectionBuilder()
    .withUrl(apiBaseUrl + "signalrhub")
    .build();

document.getElementById("sendbutton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours();
    var currentMinute = currentTime.getMinutes();

    var li = document.createElement("li");
    var span = document.createElement("span");
    span.style.fontWeight = "bold";
    span.textContent = user;

    li.appendChild(span);
    li.appendChild(document.createTextNode(`: ${message} - ${currentHour}:${currentMinute}`));
    document.getElementById("messagelist").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendbutton").disabled = false;
}).catch(function (error) {
    return console.error(error.toString());
});

document.getElementById("sendbutton").addEventListener("click", function (event) {
    var user = document.getElementById("userinput").value;
    var message = document.getElementById("messageinput").value;

    connection.invoke("SendMessage", user, message).catch(function (error) {
        return console.error(error.toString());
    });

    event.preventDefault();
});
