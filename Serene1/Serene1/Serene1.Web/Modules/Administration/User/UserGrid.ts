namespace Serene1.Administration {

    @Serenity.Decorators.registerClass()
    export class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey() { return "Administration.User"; }
        protected getDialogType() { return UserDialog; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getIsActiveProperty() { return UserRow.isActiveProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getService() { return UserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getDefaultSortBy() {
            var nodes = [
                {
                    id: 'Start', width: 140, height: 50, offsetX: 300, offsetY: 50,
                    annotations: [{
                        id: 'label1',
                        content: 'Start'
                    }],
                    shape: { type: 'Flow', shape: 'Terminator' }
                }
            ];

             // @ts-ignore
            var diagram = new ej.diagrams.Diagram({
                width: '800px', height: '600px', nodes: nodes
            }, '#element');;
            return [UserRow.Fields.Username];
        }
    }
}