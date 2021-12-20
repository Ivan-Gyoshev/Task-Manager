import { url } from './apiServer'

const assignmentsUrl = url + "assignments";

export const getAll = () => {
    return fetch(assignmentsUrl)
    .then(res => res.json())
    .catch(err => console.log(err))
};