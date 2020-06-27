var rows = document.getElementsByClassName("orderDetailsRow");
for (var i = 0; i < rows.length; i++) {
    rows[i].classList.add("hide");
}

function ToggleDetails(id, event) {
    var element = document.getElementById(id);

    if (element.classList.contains("hide")) {
        element.classList.remove("hide");
        event.target.innerText = "Hide"
    }
    else {
        event.target.innerText = "Details"
        element.classList.add("hide");
    }
}