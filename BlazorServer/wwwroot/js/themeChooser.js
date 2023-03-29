window.themeChooser = {
    setTheme: function (themeName) {
        // Build the new css link

        let html = document.getElementById("html");
        html.setAttribute("data-bs-theme", themeName);
        
    }
}