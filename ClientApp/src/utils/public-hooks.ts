export const getPkFromModel = (model: any) => {
    let result = [];
    const arrayModel = model ? Object.entries(model) : [];
    for (let i = 0; i < arrayModel.length; i++) {
        if (arrayModel[i][0] === '_id') {
            result.push(arrayModel[i][1]);
        }
    }
    return result;
}

