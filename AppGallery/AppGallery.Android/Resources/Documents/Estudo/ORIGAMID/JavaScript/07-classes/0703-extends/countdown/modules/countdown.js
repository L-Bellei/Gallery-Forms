export default class Countdown {
    constructor(futureDate) {
        this.futureDate = futureDate;
    }

    get _futureDate() {
        return new Date(this.futureDate)
    }
}