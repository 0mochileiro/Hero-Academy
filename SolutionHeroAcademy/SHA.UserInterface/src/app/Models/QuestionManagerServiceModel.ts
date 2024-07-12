export class ResponseGetRandomQuestion {

    ok: boolean | undefined;
    message: string | undefined;
    result: Question | undefined;
}

export class Question {
    id: string | undefined;
    questionCategory: number | undefined;
    statement: string | undefined;
    answers: Answer[] | undefined;
}

export class Answer {
    id: string | undefined;
    questionID: string | undefined;
    value: string | undefined;
    correct: boolean | undefined;
}