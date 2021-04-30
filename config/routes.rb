Rails.application.routes.draw do
  resources :system, controller: 'controllers/system_controller'

  root to: "system#index"
end
