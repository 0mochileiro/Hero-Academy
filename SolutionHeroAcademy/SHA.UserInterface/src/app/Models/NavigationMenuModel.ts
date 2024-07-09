export class NavigationMenuModel {
    settings: NavigationSetting[] = [];

    constructor() {
        this.settings.push(new NavigationSetting('abde104a-f233-472f-8b52-05406709de2c', 'App', 'Home', 'home', 'bi bi-house-fill', 'bi bi-app-indicator', true));
        this.settings.push(new NavigationSetting('582e04d8-e6b8-4417-bcbf-df26434e46a0', 'App', 'Play', 'game', 'bi bi-house-fill', 'bi bi-app-indicator', false));
        this.settings.push(new NavigationSetting('d4f50d95-899e-4e66-939f-c13353f86d11', 'Characters', 'Characters', 'hero', 'bi bi-people-fill', 'bi bi-people-fill', true)); // Todo: review.
        this.settings.push(new NavigationSetting('f7b09e0b-e542-428d-98eb-14abaf015c8e', 'Characters', 'New character', '#', 'bi-person-fill-add', 'bi bi-people-fill', false)); // Todo: review.
    }

    getGroupedSettings(): { [key: string]: { icon: string, items: NavigationSetting[] } } {
        return this.settings.reduce((groups, setting) => {
            if (!groups[setting.group]) {
                groups[setting.group] = { icon: setting.groupIcon, items: [] };
            }
            groups[setting.group].items.push(setting);
            return groups;
        }, {} as { [key: string]: { icon: string, items: NavigationSetting[] } });
    }
}

export class NavigationSetting {
    id: string;
    group: string;
    name: string;
    path: string;
    groupIcon: string;
    icon: string;
    active: boolean;

    constructor(id: string, group: string, name: string, path: string, icon: string, groupIcon: string, active: boolean) {
        this.id = id;
        this.group = group;
        this.name = name;
        this.path = path;
        this.groupIcon = groupIcon;
        this.icon = icon;
        this.active = active
    }
}