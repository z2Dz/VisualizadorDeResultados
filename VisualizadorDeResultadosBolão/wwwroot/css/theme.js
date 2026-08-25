// ==========================================================================
// THEME MANAGER
// Lista central de temas disponíveis + persistência em localStorage.
// "default" é o visual original do app (sem data-theme aplicado).
// ==========================================================================

window.themeManager = {
    themes: [
        { id: "retroos", label: "Retro OS" },
        { id: "afc", label: "AFC" },
        { id: "sketch", label: "Desenho à Mão" },
        { id: "minimal", label: "Minimalista" },
        { id: "brutal", label: "Neobrutalista" },
        { id: "pixel", label: "Pixel Art" },
        { id: "retro", label: "Retrofuturista" }
    ],

    getThemes: function () {
        return this.themes;
    },

    setTheme: function (theme) {
        if (theme === "default") {
            document.documentElement.removeAttribute("data-theme");
        } else {
            document.documentElement.setAttribute("data-theme", theme);
        }
        localStorage.setItem("theme", theme);
    },

    loadTheme: function () {
        const saved = localStorage.getItem("theme") || "default";
        this.setTheme(saved);
        return saved;
    }
};