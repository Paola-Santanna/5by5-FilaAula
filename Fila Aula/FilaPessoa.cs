using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Aula
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Pessoa aux) //Método de inserir
        {
            if (IsEmpty())
            {
                head = tail = aux;
                /*
                 * É a mesma coisa:
                 * head = aux;
                 * tail = aux
                 */
            }
            else
            {
                tail.setNext(aux);
                tail = aux;
            }

        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                if (head == tail) //verifico se tenho um elemento só
                {
                    head = tail = null;
                }
                else
                {
                    this.head = this.head.getNext();
                }
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

    }
}
