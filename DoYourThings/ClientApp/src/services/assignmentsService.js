import { url } from './apiServer'

const assignmentsUrl = url + "assignments";

export const getAll = (values) => {
    return fetch(assignmentsUrl, {
        method: "GET",
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(values)
    })
    .then(res => res.json)
    .catch(err => console.log(err))
};