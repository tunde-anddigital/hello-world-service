import express from 'express';
import { getHelloWorld } from '../services/helloService'
import ErrorTemplate from '../utilities/errorHandler';

const router = express.Router();

router.get('/', async (req, res) => {
    console.log('sup!')
    try {
        const helloResponse = await getHelloWorld();
        if (!helloResponse) {
            const notFoundError = new ErrorTemplate('Hello world not found', 'NotFoundError');
            res.status(404).send({
                error: notFoundError
            })
        }
        console.log(helloResponse)
        res.status(200).send(helloResponse)
    } catch (error) {
        const internalServerError = new ErrorTemplate(`An internal server error occurred in helloWorldRouter: ${error.message}`, 'internalServerError');
        res.status(404).send({
            error: internalServerError
        })
    }

});

export default router