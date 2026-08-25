// ==========================================================================
// THEME MANAGER
// Lista central de temas disponíveis + persistência em localStorage.
// Sempre há um data-theme aplicado; "minimal" (primeiro da lista) é o
// tema usado quando não há nada salvo ainda.
// ==========================================================================

window.themeManager = {
    themes: [
        { id: "minimal", label: "Minimalista" },
        { id: "afc", label: "AFC" },
        { id: "sketch", label: "Desenho à Mão" },
        { id: "retroos", label: "Retro OS" },
        { id: "brutal", label: "Neobrutalista" },
        { id: "pixel", label: "Pixel Art" },
        { id: "retro", label: "Retrofuturista" }
    ],

    getThemes: function () {
        return this.themes;
    },

    setTheme: function (theme) {
        document.documentElement.setAttribute("data-theme", theme);
        localStorage.setItem("theme", theme);
    },

    loadTheme: function () {
        const valid = this.themes.some(t => t.id === localStorage.getItem("theme"));
        const saved = valid ? localStorage.getItem("theme") : this.themes[0].id;
        this.setTheme(saved);
        return saved;
    }
};