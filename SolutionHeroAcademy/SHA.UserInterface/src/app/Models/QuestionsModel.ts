export class QuestionModel {

    id: string = '012c65f3-0429-4ad8-8db7-2ea92f52f3cf';
    question: string = 'What was the global impact of the Industrial Revolution on the contemporary world?';
    category: string = 'History'
    answers: Answer[] = [];

    constructor() {
        this.answers.push(new Answer('1561f1a2-2cbf-444b-bdc4-6a0808adaf5e', '012c65f3-0429-4ad8-8db7-2ea92f52f3cf', 'The Industrial Revolution had no impact on the contemporary world.', false));
        this.answers.push(new Answer('b779faec-faa3-4d21-a896-184920131c87', '012c65f3-0429-4ad8-8db7-2ea92f52f3cf', 'The Industrial Revolution shaped the global economy and modern society.', true));
        this.answers.push(new Answer('ce45dc73-5edb-4901-a567-7c821cfc3451', '012c65f3-0429-4ad8-8db7-2ea92f52f3cf', 'The Industrial Revolution led to the isolation of nations and communities.', false));
        this.answers.push(new Answer('8f11785a-c6a3-430c-9990-73904fed564d', '012c65f3-0429-4ad8-8db7-2ea92f52f3cf', 'The Industrial Revolution promoted self-sufficiency for all nations.', false));
    }
}

export class Answer {

    id: string | undefined;
    questionId: string | undefined;
    answer: string | undefined;
    correct: boolean | undefined;

    constructor(id: string, questionId: string, answer: string, correct: boolean) {
        this.id = id;
        this.questionId = questionId;
        this.answer = answer;
        this.correct = correct;
    }
}
