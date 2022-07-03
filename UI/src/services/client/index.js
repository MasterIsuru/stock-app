import axios from "axios";

const options = {
  baseURL: process.env.REACT_APP_BASE_URL,
};

export const axiosClient = axios.create(options);

axiosClient.interceptors.request.use(
  async (config) => {
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

axiosClient.interceptors.response.use(
  (response) => {
    return response;
  },
  (error) => {
    return Promise.reject(error);
  }
);
