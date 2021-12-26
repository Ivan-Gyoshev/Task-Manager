import { url } from "./apiServer";

const assignmentsUrl = url + "assignments";

export const getCurrent = (id) => {
  return fetch(assignmentsUrl + `/${id}`)
    .then((res) => res.json())
    .catch((err) => console.log(err));
};

export const getAll = () => {
  return fetch(assignmentsUrl)
    .then((res) => res.json())
    .catch((err) => console.log(err));
};

export const deleted = (id) => {
  return fetch(assignmentsUrl + `/${id}`, {
    method: "DELETE",
  })
    .then((res) => res.json())
    .catch((error) => console.log(error));
};

export const create = () => {
  return fetch(assignmentsUrl, {
    method: "POST",
  })
    .then((res) => res.json())
    .catch((error) => console.log(error));
}