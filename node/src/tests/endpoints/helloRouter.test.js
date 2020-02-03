import supertest from 'supertest';
import app from '../../app';

const request = supertest(app);

describe('Getting Hello World string from end point', () => {

    it("Get - succesafully returns json with hello world string", (done) => {

        request
            .get('/worlds')
            .set("Accept", "application/json")
            // Assert
            .expect("Content-Type", /json/)
            .expect(200)
            .expect(({ body }) => {
                expect(body.data).not.toBeNull();
                expect(body.data).toBe('Hello World!!!')
            })
            .end((err, response) => {
                if (err) return done(err);
                done();
            });




    })
})