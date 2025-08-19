function toggleHideMe() {
    const elements = document.getElementsByClassName("hide_me");
    for (let element of elements) {
        if (element.style.display === "block" || element.style.display === "") {
            element.style.display = "none";
        } else {
            element.style.display = "block";
        }
    }
}