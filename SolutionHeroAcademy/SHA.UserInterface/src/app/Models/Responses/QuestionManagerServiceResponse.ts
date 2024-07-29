export interface ResponseGetRandomQuestion {
    ok: boolean;
    message: string;
    result: Question;
}

export interface Question {
    id: string | undefined;
    questionCategory: number;
    statement: string;
    answers: Answer[];
}

export interface Answer {
    id: string;
    questionID: string;
    value: string;
    correct: boolean;
}