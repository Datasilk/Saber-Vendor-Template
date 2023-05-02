//loaded when Saber's editor is loaded
S.editor.template = {
    add: {
        show: function () {
            //display form to add new template item
            S.ajax.post('TemplateContent/RenderAdd', {}, (html) => {
                S.popup.show("Add Template Content", html, {width:'100%', maxWidth:450});
            });
        },
        save: function () {
            //finish adding new template item
            var data = {
                text: $('#text').val()
            };
            S.ajax.post('TemplateContent/Add', data,
                function (response) {
                    //update list of template items
                    S.popup.hide();
                },
                function (err) {
                    S.editor.error('.popup .msg', err.responseText);
                });
        }
    }
};

//create a new top menu item
S.editor.topmenu.add('template', 'Template');
S.editor.dropmenu.add('.menu-bar .menu-item-template > .drop-menu > .menu', 'template-add', 'New Template Item', '#icon-add-sm', false, S.editor.template.add.show);