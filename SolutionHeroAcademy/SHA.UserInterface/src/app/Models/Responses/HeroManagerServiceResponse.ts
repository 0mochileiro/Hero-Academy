export interface ResponseGetRandomHero {
    ok: boolean;
    message: string;
    result: Hero;
}

export interface Hero {
    id: string;
    name: string;
    skill: string;
    history: string;
    health: number;
    attack: number;
}