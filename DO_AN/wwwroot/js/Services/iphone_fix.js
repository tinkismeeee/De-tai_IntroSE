document.querySelectorAll('.tab-menu li').forEach(tab => {
    tab.addEventListener('click', function() {
        let tabId = this.getAttribute('data-tab');

        document.querySelectorAll('.tab-menu li').forEach(item => {
            item.classList.remove('active');
        });

        this.classList.add('active');

        document.querySelectorAll('.tab-pane').forEach(pane => {
            pane.classList.remove('active');
        });

        document.getElementById(tabId).classList.add('active');
    });
});
