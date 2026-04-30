window.pwaInstall = {
    deferredPrompt: null,

    isInstalled: function () {
        return window.matchMedia('(display-mode: standalone)').matches
            || window.navigator.standalone === true;
    },

    canInstall: function () {
        return window.pwaInstall.deferredPrompt !== null;
    },

    init: function () {
        window.addEventListener('beforeinstallprompt', function (e) {
            e.preventDefault();
            window.pwaInstall.deferredPrompt = e;
            console.log("PWA pronto para instalar");
        });

        window.addEventListener('appinstalled', function () {
            window.pwaInstall.deferredPrompt = null;
            console.log("PWA instalado");
        });
    },

    promptInstall: async function () {
        if (!window.pwaInstall.deferredPrompt) {
            console.log("PWA ainda não está disponível para instalar");
            return false;
        }

        window.pwaInstall.deferredPrompt.prompt();

        const result = await window.pwaInstall.deferredPrompt.userChoice;

        window.pwaInstall.deferredPrompt = null;

        return result.outcome === "accepted";
    }
};

window.pwaInstall.init();