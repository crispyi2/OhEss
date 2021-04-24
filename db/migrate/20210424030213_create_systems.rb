class CreateSystems < ActiveRecord::Migration[6.0]
  def change
    create_table :systems do |t|

      t.timestamps
    end
  end
end
