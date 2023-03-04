pipeline
{
    agent any
    
    stages
    {
        stage('Checkout')
        {
            steps
            {
                git branch: 'features/TestCaseImprovement', credentialsId: 'GitPat', url: 'https://github.com/rpsingh77/Weather.git'
            }
            
        }
    }
}